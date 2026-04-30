using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04
{
    internal abstract class GeometricFigure
    {
        double A;
        double B;
        double C;
        double D;

        public abstract double S_Math(double a, double b, double c, double d);
        public abstract double P_Math(double a, double b, double c, double d);
    }
}
