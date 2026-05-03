using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04.Figuress
{
    internal class Rectangle : GeometricFigure
    {
        private double A;
        private double B;

        public static GeometricFigure Initialization()
        {
            Console.WriteLine("Введите размеры прямоугольника");
            Console.Write("Сторона 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сторона 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            GeometricFigure figure = new Rectangle(a, b);
            return figure;
        }

        public Rectangle(double a, double b)
        {
            A = a; B = b;
        }
        public override double P_Math()
        {
            return (A + B) * 2;
        }

        public override double S_Math()
        {
            return A * B;
        }
    }
}
