using System.Diagnostics;

namespace CSH_DZ_2._10._2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(() =>
            {
                Console.WriteLine("[Поток 1] Запуск потока.");
                Console.WriteLine("[Поток 1] Запуск Notepad.");

                var psi = new ProcessStartInfo
                {
                    FileName = "notepad",
                    UseShellExecute = false
                };

                using (Process proc = Process.Start(psi))
                {
                    Console.WriteLine("[Поток 1] Ожидание завершения Notepad...");
                    Thread.Sleep(3000);
                    //proc.CloseMainWindow();
                }


                Process.Start(new ProcessStartInfo
                {
                    FileName = "taskkill.exe",
                    Arguments = "/IM Notepad.exe /F",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }).WaitForExit();

                Console.WriteLine("[Поток 1] Поток завершён.");
            })
            {
                Name = "Поток 1"
            };

            var thread2 = new Thread(() =>
            {
                Console.WriteLine("[Поток 2] Запуск потока.");
                Console.WriteLine("[Поток 2] Запуск cmd.exe.");
                var psi = new ProcessStartInfo
                {
                    FileName = "cmd",
                    Arguments = "/c dir",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                using (Process proc = Process.Start(psi))
                {
                    Console.WriteLine("[Поток 2] Выполнение команды dir.");

                    string output = proc.StandardOutput.ReadToEnd();
                    proc.WaitForExit();

                    Console.WriteLine(output);
                }

                Console.WriteLine("[Поток 2] Поток завершён.");
            })
            {
                Name = "Поток 2"
            };

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }
    }
}
