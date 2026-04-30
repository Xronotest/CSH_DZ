using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04
{
    internal class Square : GeometricFigure
    {
        public override double P_Math(double a, double b, double c, double d)
        {
            return a * 4;
        }

        public override double S_Math(double a, double b, double c, double d)
        {
            return a * a;
        }
    }
}
