using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__DZ_26._03
{
    public class Bank
    {

        static public void Math(double P)
        {
            int K = 0;
            double start = 10000;
            if (P < 1 || P > 24)
            {
                Console.WriteLine("P выходит за пределы");
            }
            else
            {
                P *= 0.01;
                do
                {
                    K++;
                    start += start * P;
                }
                while (start < 11000);
                double S = start;
                Console.Write($"Кол-во месяцев: {K}");
                Console.WriteLine(" ");
                Console.Write($"Итоговая ссума: {S}");

            }
        }
    }
}
