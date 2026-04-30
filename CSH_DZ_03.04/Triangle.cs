using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04
{
    internal class Triangle : GeometricFigure
    {
        public override double P_Math(double a, double b, double c, double d)
        {
            return a + b + c;
        }

        public override double S_Math(double a, double b, double c, double d)
        {
            return Math.Sqrt((((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c))); 
        }
    }
}
