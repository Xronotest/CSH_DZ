using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04.Figuress
{
    internal class Triangle : GeometricFigure
    {
        private double A;
        private double B;
        private double C;

        public Triangle(double a, double b, double c) 
        { 
            A = a; B = b; C = c;
        }

        public static GeometricFigure Initialization()
        {
            Console.WriteLine("Введите размеры треугольника");
            Console.Write("Сторона 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сторона 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сторона 3: ");
            double c = Convert.ToDouble(Console.ReadLine());
            GeometricFigure figure = new Triangle(a, b, c);
            return figure;
        }

        public override double P_Math()
        {
            return A + B + C;
        }

        public override double S_Math()
        {
            return Math.Sqrt((A + B + C) / 2 * ((A + B + C) / 2 - A) * ((A + B + C) / 2 - B) * ((A + B + C) / 2 - C)); 
        }
    }
}
