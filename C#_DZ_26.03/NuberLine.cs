using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__DZ_26._03
{
    public class NuberLine
    {
        static public void Line(int A, int B)
        {
            if (A < 0 || B < 0)
            {
                Console.WriteLine("Вы ввели отрицательные значения!");
            }
            else
            {
                for (int i = 0; i < B - A + 1; i++)
                {
                    for (int j = 0; j < A + i; j++)
                    {
                        Console.Write(A + i);
                    }
                    Console.WriteLine(" ");
                }
            }


        }
    }
}
