using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_26_03_2
{
    internal class Task_1
    {
        static public void Zero(int size)
        {
            int[] arr = new int[size];
            int[] temp = new int[size];
            int temp_ = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Введите {i + 1} число: ");
                temp[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Созданн массив: ");
            Program.PrintArr(temp);

            for (int i = 0;i < arr.Length; i++)
            {
                if (temp[i] != 0)
                {
                    arr[temp_] = temp[i];
                    temp_++;
                }
            }
            for (int i = temp_; i < arr.Length; i++)
            {
                arr[i] = -1;
            }

            Console.Write("Результат: ");
            Program.PrintArr(arr);

        }
    }
}
