using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_26_03_2
{
    internal class Task_3
    {
        static public void NumSeach(int size, int number)
        {
            int[] arr = new int[size];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите {i + 1} число: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Созданн массив: ");
            Program.PrintArr(arr);

            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }

            Console.Write($"Кол-во числа {number} в массиве составляет: {count}");
        }
    }
}
