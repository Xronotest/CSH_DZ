namespace C__DZ_26._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int userChoise = Convert.ToInt32(Console.ReadLine());

            if (userChoise == 1)
            {
                Console.Write("Введите A: ");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите B: ");
                int B = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите C: ");
                int C = Convert.ToInt32(Console.ReadLine());

                Math_Figure.Math(A, B, C);
            }
            
            else if (userChoise == 2)
            {
                Console.Write("Введите P: ");
                double P = Convert.ToInt32(Console.ReadLine());

                Bank.Math(P);
            }

            else if (userChoise == 3)
            {
                Console.Write("Введите A: ");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите B: ");
                int B = Convert.ToInt32(Console.ReadLine());

                NuberLine.Line(A, B);
            }

            else if (userChoise == 4)
            {
                Console.Write("Введите N: ");
                int N = Convert.ToInt32(Console.ReadLine());

                Task_4.N_Math(N);
            }

        }
    }
}
