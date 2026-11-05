using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text;

namespace CSH_DZ_31._10._2026;

internal static class Program
{
    private const int cellCount = 30;
    private const int chargerSlots = 3;
    private const int diagnosticIterations = 100000;
    private const int minChargeDurationMs = 300;
    private const int maxChargeDurationMs = 900;
    private const int minCalibrationDurationMs = 100;
    private const int maxCalibrationDurationMs = 300;
    private const int AutoCancelMs = 2000;

    private static readonly TimeSpan CancellationWaitLimit = TimeSpan.FromSeconds(10);

    private static int Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<BatteryCell> cells = CreateBatch();
        var cancellationSource = new CancellationTokenSource();
        var chargerSemaphore = new SemaphoreSlim(chargerSlots, chargerSlots);
        var calibrationMutex = new Mutex(initiallyOwned: false);
        var completion = new CountdownEvent(cells.Count);
        var logger = new StationLogger();
        var context = new StationContext
            (
                cancellationSource.Token,
                chargerSemaphore,
                calibrationMutex,
                completion,
                logger
            );

        ConsoleCancelEventHandler cancelHandler = (_, eventArgs) =>
        {
            eventArgs.Cancel = true;
            try
            {
                cancellationSource.Cancel();
            }
            catch (ObjectDisposedException)
            {
            }
        };

        Console.CancelKeyPress += cancelHandler;
        using CancellationTokenRegistration cancellationLog = cancellationSource.Token.Register
            (
                () => logger.LogSystem("Запрошена аварийная остановка", "Stopping")
            );

        Stopwatch batchTimer = Stopwatch.StartNew();

        try
        {
            PrintThreadPoolInfo("Пул потоков до запуска");
            logger.LogSystem($"Партия создана: {cells.Count} ячеек; слотов зарядки: {chargerSlots}", "Running");

            if (AutoCancelMs > 0)
            {
                cancellationSource.CancelAfter(AutoCancelMs);
                logger.LogSystem($"Автоматическая отмена через {AutoCancelMs} мс", "Running");
            }
            foreach (BatteryCell cell in cells)
            {
                logger.Log(cell.Id, "Ячейка поставлена в очередь", CellStatus.Pending.ToString());

                var workItem = new CellWorkItem(cell, context);
                bool queued = ThreadPool.QueueUserWorkItem
                    (
                        static state =>
                        {
                            var item = (CellWorkItem)state!;
                            item.Context.ProcessCell(item.Cell);
                        },
                        workItem
                    );
                if (!queued)
                {
                    context.RegisterQueueFailure(cell, "ThreadPool.QueueUserWorkItem вернул false.");
                }
            }
            WaitForBatch(context);
            if (completion.IsSet && AutoCancelMs > 0 && !cancellationSource.IsCancellationRequested)
            {
                cancellationSource.CancelAfter(Timeout.Infinite);
            }
        }
        finally
        {
            batchTimer.Stop();
            Console.CancelKeyPress -= cancelHandler;
        }

        PrintResults(context);
        Console.WriteLine();
        PrintThreadPoolInfo("Пул потоков после завершения");
        PrintSummary(context, batchTimer.Elapsed);

        completion.Dispose();
        calibrationMutex.Dispose();
        chargerSemaphore.Dispose();
        cancellationSource.Dispose();

        logger.LogSystem("Обработка завершена", "Stopped");
        return 0;
    }

    private static List<BatteryCell> CreateBatch()
    {
        var random = new Random();
        var cells = new List<BatteryCell>(cellCount);

        for (int i = 1; i <= cellCount; i++)
        {
            cells.Add(new BatteryCell(
                Id: i,
                DiagnosticIterations: diagnosticIterations,
                ChargeDurationMs: random.Next(minChargeDurationMs, maxChargeDurationMs + 1),
                CalibrationDurationMs: random.Next(minCalibrationDurationMs, maxCalibrationDurationMs + 1)));
        }

        return cells;
    }

    private static void WaitForBatch(StationContext context)
    {
        WaitHandle[] waitHandles =
        {
            context.Completion.WaitHandle,
            context.Token.WaitHandle
        };

        int signaledHandle = WaitHandle.WaitAny(waitHandles);

        if (signaledHandle == 1 && !context.Completion.IsSet)
        {
            context.Logger.LogSystem(
                $"Ожидание завершения рабочих элементов после отмены (лимит {CancellationWaitLimit.TotalSeconds:0} с)",
                "Stopping");

            bool completedInTime = context.Completion.Wait(CancellationWaitLimit);
            if (!completedInTime)
            {
                context.Logger.LogSystem(
                    "Элементы не завершились за 10 секунд. Ожидание продолжено.",
                    "Stopping");

                context.Completion.Wait();
            }
        }
    }

    private static void PrintThreadPoolInfo(string title)
    {
        ThreadPool.GetAvailableThreads(out int availableWorkers, out int availableCompletionPorts);
        ThreadPool.GetMaxThreads(out int maxWorkers, out int maxCompletionPorts);

        Console.WriteLine($"\n{title}");
        Console.WriteLine($"Рабочие потоки: доступно {availableWorkers} из {maxWorkers}");
        Console.WriteLine($"Потоки завершения: доступно {availableCompletionPorts} из {maxCompletionPorts}");
    }

    private static void PrintResults(StationContext context)
    {
        Console.WriteLine("\nРЕЗУЛЬТАТЫ ПО ЯЧЕЙКАМ");

        foreach (CellResult result in context.Results.Values.OrderBy(result => result.CellId))
        {
            string duration = (result.FinishedAt - result.StartedAt).TotalMilliseconds.ToString("F0");
            Console.WriteLine(
                $"Ячейка {result.CellId,2}: {result.Status,-9} | " +
                $"Начало {result.StartedAt:HH:mm:ss.fff} | " +
                $"Конец {result.FinishedAt:HH:mm:ss.fff} | " +
                $"{duration} мс" +
                (string.IsNullOrWhiteSpace(result.ErrorMessage) ? string.Empty : $" | Ошибка: {result.ErrorMessage}"));
        }
    }

    private static void PrintSummary(StationContext context, TimeSpan elapsed)
    {
        StationStatistics statistics = context.GetStatistics();

        Console.WriteLine("\nРЕЗУЛЬТАТ");
        Console.WriteLine($"Всего ячеек:                        {context.Results.Count}");
        Console.WriteLine($"Completed:                          {statistics.Completed}");
        Console.WriteLine($"Canceled:                           {statistics.Canceled}");
        Console.WriteLine($"Faulted:                            {statistics.Faulted}");
        Console.WriteLine($"Всего по итоговым статусам:         {statistics.Completed + statistics.Canceled + statistics.Faulted}");
        Console.WriteLine($"Время обработки партии:             {elapsed.TotalSeconds:F2} с");
        Console.WriteLine($"Успешных зарядок:                   {statistics.SuccessfulCharges}");
        Console.WriteLine($"Успешных калибровок:                {statistics.SuccessfulCalibrations}");
        Console.WriteLine($"Отмен зарядки:                      {statistics.CanceledChargerWaits}");
        Console.WriteLine($"Отмен калибровки:                   {statistics.CanceledCalibrationWaits}");
        Console.WriteLine($"Максимум зарядок:                   {statistics.MaxConcurrentChargers} (слотов: {chargerSlots})");
        Console.WriteLine($"Максимум калибровок:                {statistics.MaxConcurrentCalibrations}");
        Console.WriteLine($"Контрольная сумма:                  {statistics.DiagnosticChecksum}");
    }
}

internal sealed record BatteryCell(
    int Id,
    int DiagnosticIterations,
    int ChargeDurationMs,
    int CalibrationDurationMs);

internal sealed record CellWorkItem(BatteryCell Cell, StationContext Context);

internal enum CellStatus
{
    Pending,
    Diagnostics,
    WaitingForCharger,
    Charging,
    WaitingForCalibration,
    Calibration,
    Completed,
    Canceled,
    Faulted
}

internal sealed record CellResult(
    int CellId,
    CellStatus Status,
    DateTimeOffset StartedAt,
    DateTimeOffset FinishedAt,
    string? ErrorMessage);

internal sealed class StationContext
{
    private readonly SemaphoreSlim _chargerSemaphore;
    private readonly Mutex _calibrationMutex;
    private readonly StationLogger _logger;
    private long _completed;
    private long _canceled;
    private long _faulted;
    private long _successfulCharges;
    private long _successfulCalibrations;
    private long _canceledChargerWaits;
    private long _canceledCalibrationWaits;
    private long _diagnosticChecksum;
    private int _activeChargers;
    private int _maxConcurrentChargers;
    private int _activeCalibrations;
    private int _maxConcurrentCalibrations;

    public StationContext(
        CancellationToken token,
        SemaphoreSlim chargerSemaphore,
        Mutex calibrationMutex,
        CountdownEvent completion,
        StationLogger logger)
    {
        Token = token;
        _chargerSemaphore = chargerSemaphore;
        _calibrationMutex = calibrationMutex;
        Completion = completion;
        _logger = logger;
    }

    public CancellationToken Token { get; }
    public CountdownEvent Completion { get; }
    public StationLogger Logger => _logger;
    public ConcurrentDictionary<int, CellResult> Results { get; } = new();

    public void ProcessCell(BatteryCell cell)
    {
        DateTimeOffset startedAt = DateTimeOffset.Now;
        CellStatus status = CellStatus.Pending;
        string? errorMessage = null;

        try
        {
            Token.ThrowIfCancellationRequested();

            status = CellStatus.Diagnostics;
            _logger.Log(cell.Id, "Первичная диагностика начата", status.ToString());
            RunDiagnostics(cell);
            _logger.Log(cell.Id, "Первичная диагностика завершена", status.ToString());

            status = CellStatus.WaitingForCharger;
            _logger.Log(cell.Id, "Ожидание слота зарядки", status.ToString());

            bool chargerAcquired = false;
            try
            {
                try
                {
                    _chargerSemaphore.Wait(Token);
                    chargerAcquired = true;
                }
                catch (OperationCanceledException)
                {
                    Interlocked.Increment(ref _canceledChargerWaits);
                    throw;
                }

                _logger.Log(cell.Id, "Слот зарядки получен", status.ToString());
                Token.ThrowIfCancellationRequested();

                status = CellStatus.Charging;
                int activeChargers = Interlocked.Increment(ref _activeChargers);
                UpdateMaximum(ref _maxConcurrentChargers, activeChargers);
                _logger.Log(cell.Id, $"Зарядка начата ({cell.ChargeDurationMs} мс)", status.ToString());

                WaitInterruptibly(cell.ChargeDurationMs);
                Interlocked.Increment(ref _successfulCharges);
                _logger.Log(cell.Id, "Зарядка завершена", status.ToString());
            }
            finally
            {
                if (chargerAcquired)
                {
                    if (status == CellStatus.Charging)
                    {
                        Interlocked.Decrement(ref _activeChargers);
                    }

                    _chargerSemaphore.Release();
                    _logger.Log(cell.Id, "Слот зарядки освобождён", status.ToString());
                }
            }

            Token.ThrowIfCancellationRequested();

            status = CellStatus.WaitingForCalibration;
            _logger.Log(cell.Id, "Ожидание калибровочного стенда", status.ToString());

            bool mutexAcquired = false;
            bool calibrationStarted = false;
            try
            {
                try
                {
                    int waitResult = WaitHandle.WaitAny(new WaitHandle[]
                    {
                        _calibrationMutex,
                        Token.WaitHandle
                    });

                    if (waitResult == 1)
                    {
                        Interlocked.Increment(ref _canceledCalibrationWaits);
                        throw new OperationCanceledException(Token);
                    }

                    mutexAcquired = true;
                }
                catch (AbandonedMutexException)
                {
                    mutexAcquired = true;
                    _logger.Log(cell.Id, "Предупреждение: получен освобождённый аварийно мьютекс", status.ToString());
                }

                if (Token.IsCancellationRequested)
                {
                    Interlocked.Increment(ref _canceledCalibrationWaits);
                    throw new OperationCanceledException(Token);
                }

                _logger.Log(cell.Id, "Калибровочный стенд получен", status.ToString());
                status = CellStatus.Calibration;
                calibrationStarted = true;

                int activeCalibrations = Interlocked.Increment(ref _activeCalibrations);
                UpdateMaximum(ref _maxConcurrentCalibrations, activeCalibrations);
                _logger.Log(cell.Id, $"Калибровка начата ({cell.CalibrationDurationMs} мс)", status.ToString());

                WaitInterruptibly(cell.CalibrationDurationMs);
                Interlocked.Increment(ref _successfulCalibrations);
                _logger.Log(cell.Id, "Калибровка завершена", status.ToString());
            }
            finally
            {
                if (mutexAcquired)
                {
                    if (calibrationStarted)
                    {
                        Interlocked.Decrement(ref _activeCalibrations);
                    }
                    _calibrationMutex.ReleaseMutex();
                    _logger.Log(cell.Id, "Калибровочный стенд освобождён", status.ToString());
                }
            }

            Token.ThrowIfCancellationRequested();
            status = CellStatus.Completed;
        }
        catch (OperationCanceledException) when (Token.IsCancellationRequested)
        {
            status = CellStatus.Canceled;
            _logger.Log(cell.Id, "Обработка ячейки отменена", status.ToString());
        }
        catch (Exception exception)
        {
            status = CellStatus.Faulted;
            errorMessage = exception.ToString();
            _logger.Log(cell.Id, $"Произошла ошибка: {exception.Message}", status.ToString());
        }
        finally
        {
            DateTimeOffset finishedAt = DateTimeOffset.Now;
            var result = new CellResult(cell.Id, status, startedAt, finishedAt, errorMessage);

            try
            {
                RegisterResult(result);
                _logger.Log(cell.Id, "Ячейка завершила обработку", status.ToString());
            }
            finally
            {
                Completion.Signal();
            }
        }
    }

    public void RegisterQueueFailure(BatteryCell cell, string message)
    {
        DateTimeOffset now = DateTimeOffset.Now;
        var result = new CellResult(cell.Id, CellStatus.Faulted, now, now, message);
        RegisterResult(result);
        _logger.Log(cell.Id, $"Не удалось поставить ячейку в очередь: {message}", CellStatus.Faulted.ToString());
        Completion.Signal();
    }

    public StationStatistics GetStatistics()
    {
        return new StationStatistics(
            Interlocked.Read(ref _completed),
            Interlocked.Read(ref _canceled),
            Interlocked.Read(ref _faulted),
            Interlocked.Read(ref _successfulCharges),
            Interlocked.Read(ref _successfulCalibrations),
            Interlocked.Read(ref _canceledChargerWaits),
            Interlocked.Read(ref _canceledCalibrationWaits),
            Volatile.Read(ref _maxConcurrentChargers),
            Volatile.Read(ref _maxConcurrentCalibrations),
            Interlocked.Read(ref _diagnosticChecksum));
    }

    private void RunDiagnostics(BatteryCell cell)
    {
        long checksum = 0;

        for (int i = 1; i <= cell.DiagnosticIterations; i++)
        {
            checksum = (checksum + i * 17L) % 1_000_000_007;

            if ((i & 1023) == 0)
            {
                Token.ThrowIfCancellationRequested();
            }
        }

        Token.ThrowIfCancellationRequested();
        Interlocked.Add(ref _diagnosticChecksum, checksum);
    }

    private void WaitInterruptibly(int milliseconds)
    {
        if (Token.WaitHandle.WaitOne(milliseconds))
        {
            throw new OperationCanceledException(Token);
        }
    }

    private void RegisterResult(CellResult result)
    {
        if (!Results.TryAdd(result.CellId, result))
        {
            throw new InvalidOperationException($"Результат ячейки {result.CellId} уже зарегистрирован.");
        }

        switch (result.Status)
        {
            case CellStatus.Completed:
                Interlocked.Increment(ref _completed);
                break;
            case CellStatus.Canceled:
                Interlocked.Increment(ref _canceled);
                break;
            case CellStatus.Faulted:
                Interlocked.Increment(ref _faulted);
                break;
        }
    }

    private static void UpdateMaximum(ref int maximum, int value)
    {
        int current;
        do
        {
            current = Volatile.Read(ref maximum);
            if (value <= current)
            {
                return;
            }
        }
        while (Interlocked.CompareExchange(ref maximum, value, current) != current);
    }
}

internal sealed class StationLogger
{
    private readonly object _sync = new();

    public void Log(int cellId, string message, string status)
    {
        WriteLine(cellId.ToString(), message, status);
    }

    public void LogSystem(string message, string status)
    {
        WriteLine("Станция", message, status);
    }

    private void WriteLine(string cellId, string message, string status)
    {
        lock (_sync)
        {
            try
            {
                Console.WriteLine(
                    $"[{DateTimeOffset.Now:HH:mm:ss.fff}] " +
                    $"[TID {Environment.CurrentManagedThreadId,2}] " +
                    $"[CID {cellId,7}] " +
                    $"[{status,-22}] {message}");
            }
            catch
            {
            }
        }
    }
}

internal sealed record StationStatistics(
    long Completed,
    long Canceled,
    long Faulted,
    long SuccessfulCharges,
    long SuccessfulCalibrations,
    long CanceledChargerWaits,
    long CanceledCalibrationWaits,
    int MaxConcurrentChargers,
    int MaxConcurrentCalibrations,
    long DiagnosticChecksum);
