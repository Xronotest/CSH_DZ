using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04.Figuress
{
    internal class Parallelogram : GeometricFigure
    {
        private double A;
        private double B;
        private double C;

        public static GeometricFigure Initialization()
        {
            Console.WriteLine("Введите размеры паралелограмма");
            Console.Write("Основание: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Боковая сторона: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Высота: ");
            double c = Convert.ToDouble(Console.ReadLine());
            GeometricFigure figure = new Parallelogram(a, b, c);
            return figure;
        }
        public Parallelogram(double a, double b, double c)
        {
            A = a; B = b; C = c;
        }
        public override double P_Math()
        {
            return (A + B) * 2;
        }

        public override double S_Math()
        {
            return A * C;
            // c - высота
        }
    }
}
