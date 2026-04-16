namespace CSH_DZ_26_03_2
{
    internal class Program
    {

        static public void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
            Console.WriteLine(" ");
        }


        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int userChoise = Convert.ToInt32(Console.ReadLine());

            if (userChoise == 1)
            {
                Console.Write("Введите размер массива: ");
                int size = Convert.ToInt32(Console.ReadLine());

                Task_1.Zero(size);
            }
            else if (userChoise == 2)
            {
                Console.Write("Введите размер массива: ");
                int size = Convert.ToInt32(Console.ReadLine());

                Task_2.SortArr(size);
            }

            else if (userChoise == 3)
            {
                Console.Write("Введите размер массива: ");
                int size = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите искомое число: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Task_3.NumSeach(size,number);
            }

            else if (userChoise == 4)
            {
                Console.Write("Введите длинну массива: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите высоту число: ");
                int col = Convert.ToInt32(Console.ReadLine());

                Task_4.ColonneSwap(row,col);
            }
        }


    }
}
