using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04.Figuress
{
    internal class Ellipse : GeometricFigure
    {
        // a — длина большой полуоси, b — длина малой полуоси
        private double A;
        private double B;

        public static GeometricFigure Initialization()
        {
            Console.WriteLine("Введите размеры эллипса");
            Console.Write("Длина большой полуоси: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Длина малой полуоси: ");
            double b = Convert.ToDouble(Console.ReadLine());
            GeometricFigure figure = new Ellipse(a, b);
            return figure;
        }
        public Ellipse(double a, double b)
        {
            A = a; B = b;
        }
        public override double P_Math()
        {
            return 3.14 * (A + B) * (1 + 3 * ((A - B) * (A - B)) / ((A + B) * (A + B)) / (10 + Math.Sqrt(4 - 3 * ((A - B) * (A - B)) / ((A + B) * (A + B)))));
        }

        public override double S_Math()
        {
            return 3.14 * (A * B);
        }
    }
}
