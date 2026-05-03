using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04.Figuress
{
    internal class Rhombus : GeometricFigure
    {

        private double A;
        private double B;

        public static GeometricFigure Initialization()
        {
            Console.WriteLine("Введите размеры ромба");
            Console.Write("Сторона 1: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Сторона 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            GeometricFigure figure = new Rhombus(a, b);
            return figure;
        }
        public Rhombus(double a, double b)
        {
            A = a; B = b;
        }
        public override double P_Math()
        {
            return A * 4;
        }

        public override double S_Math()
        {
            return A * B;
            // b - высота
        }
    }
}
