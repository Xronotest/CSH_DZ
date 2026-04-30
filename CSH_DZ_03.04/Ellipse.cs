using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04
{
    internal class Ellipse : GeometricFigure
    {
        // a — длина большой полуоси, b — длина малой полуоси
        public override double P_Math(double a, double b, double c, double d)
        {
            return 3.14 * (a + b) * (1 + (3 * ((a - b) * (a - b)) / ((a + b) * (a + b))) / (10 + Math.Sqrt(4 - (3 * ((a - b) * (a - b)) / ((a + b) * (a + b))))));
        }

        public override double S_Math(double a, double b, double c, double d)
        {
            return 3.14 * (a * b);
        }
    }
}
