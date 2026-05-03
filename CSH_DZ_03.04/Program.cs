namespace CSH_DZ_03._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int userChoise = Convert.ToInt32(Console.ReadLine());
            if (userChoise == 1)
            {
                GeometricFigure figure = Starter.StartFigure();

                Console.WriteLine($"Периметр фигуры: {figure.P_Math()}");
                Console.WriteLine($"Площадь фигуры: {figure.S_Math()}");
            }
            else if (userChoise == 2)
            {
                Starter.StartHumans();
            }
            else if (userChoise == 3)
            {
                Starter.StartTransport();
            }

        }
    }
}
