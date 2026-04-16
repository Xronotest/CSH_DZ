using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__DZ_26._03
{
    public class Math_Figure
    {
        static public void Math(int A, int B, int C)
        {

            if ((A * B) / (C * C) < 0 || C < 0)
            {
                Console.WriteLine("В прямоугольник не помещается ни одного крадрата или вы ввели отрицательные значения!");
            }
            else
            {
                Console.Write($"В прямоугольник помещается {(A * B) / (C * C)}");
                Console.WriteLine(" ");
                Console.Write($"Оставшееся место {(A * B) % (C * C)}");
            }
        }
    }
}
