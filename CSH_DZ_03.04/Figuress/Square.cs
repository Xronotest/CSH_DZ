using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04.Figuress
{

    internal class Square : GeometricFigure
    {
        private double A;

        public static GeometricFigure Initialization()
        {
            Console.WriteLine("Введите сторону квадрата");
            Console.Write("Сторона: ");
            double a = Convert.ToDouble(Console.ReadLine());
            GeometricFigure figure = new Square(a);
            return figure;
        }
        public Square(double a)
        {
            A = a;
        }

        public override double P_Math()
        {
            return A * 4;
        }

        public override double S_Math()
        {
            return A * A;
        }
    }
}
