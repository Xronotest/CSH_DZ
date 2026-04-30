using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04
{
    internal class Trapezoid : GeometricFigure
    {
        /*
         *  a — большее основание;
            d — меньшее основание;
            c — первая боковая сторона;
            d — вторая боковая сторона.
         */
        public override double P_Math(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }

        public override double S_Math(double a, double b, double c, double d)
        {
            return ((a + b) / 2) * (Math.Sqrt(c * c - ((((a - d) * (a - d)) + (c * c) - (d * d)) / (2 * (a - d))) * ((((a - d) * (a - d)) + (c * c) - (d * d)) / (2 * (a - d)))));
        }
    }
}
