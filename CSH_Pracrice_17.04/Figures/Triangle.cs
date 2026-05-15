using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_Pracrice_17._04.Figures
{
    internal class Triangle : Figure, ICostable
    {


        public double A {  get; set; }

        public double B { get; set; }

        public double C { get; set; }

        public Triangle(string color, string name, double a, double b, double c) : base(color, name)
        {
            A = a;
            B = b; 
            C = c;
        }

        public override double GetArea()
        {
            return Math.Sqrt((A + B + C) / 2 * ((A + B + C) / 2 - A) * ((A + B + C) / 2 - B) * ((A + B + C) / 2 - C));
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                   "\nСторона 1: " + A +
                   "\nСторона 2: " + B +
                   "\nСторона 3: " + C +
                   "\nПлощадь: " + GetArea() +
                   "\nПериметр: " + GetPerimeter();
        }
    }
}
