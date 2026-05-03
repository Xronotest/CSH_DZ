using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04.Figuress
{
    internal class Circle : GeometricFigure
    {
        // a - радиус
        private double A;

        public static GeometricFigure Initialization()
        {
            Console.WriteLine("Введите размеры круга");
            Console.Write("Радиус: ");
            double a = Convert.ToDouble(Console.ReadLine());
            GeometricFigure figure = new Circle(a);
            return figure;
        }
        public Circle(double a)
        {
            A = a;
        }
        public override double P_Math()
        {
            return A * 3.14 * 2;
        }

        public override double S_Math()
        {
            return 3.14 * (A * A);
        }
    }
}
