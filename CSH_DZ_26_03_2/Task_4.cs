using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_26_03_2
{
    internal class Task_4
    {
        static public void ColonneSwap(int row, int col)
        {
            int[,] arr = new int[row, col];
            int[,] temp = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"Введите [{i},{j}] число: ");
                    temp[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Созданн массив: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(temp[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");

            Console.Write("Введите номер заменяемого столбика: ");
            int num1 = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.Write("Введите номер заменяющего столбика: ");
            int num2 = Convert.ToInt32(Console.ReadLine()) - 1;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j == num1)
                    {
                        arr[i, num1] = temp[i, num2];
                    }
                    else if (j == num2)
                    {
                        arr[i, num2] = temp[i, num1];
                    }
                    else
                    {
                        arr[i, j] = temp[i, j];
                    }
                }
            }
            Console.WriteLine("Результат: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }

        }
    }
}
