using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04.Figuress
{
    internal class Trapezoid : GeometricFigure
    {
        /*
         *  a — большее основание;
            d — меньшее основание;
            c — первая боковая сторона;
            d — вторая боковая сторона.
         */
        private double A;
        private double B;
        private double C;
        private double D;
        public static GeometricFigure Initialization()
        {
            Console.WriteLine("Введите размеры трапеции");
            Console.Write("Большее основание: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Меньшее основание: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Первая боковая сторона: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Вторая боковая сторона: ");
            double d = Convert.ToDouble(Console.ReadLine());
            GeometricFigure figure = new Trapezoid(a, b, c, d);
            return figure;
        }

        public Trapezoid(double a, double b, double c, double d)
        {
            A = a; B = b; C = c;
            D = d;
        }
        public override double P_Math()
        {
            return A + B + C + D;
        }

        public override double S_Math()
        {
            return (A + B) / 2 * Math.Sqrt(C * C - ((A - D) * (A - D) + C * C - D * D) / (2 * (A - D)) * (((A - D) * (A - D) + C * C - D * D) / (2 * (A - D))));
        }
    }
}
