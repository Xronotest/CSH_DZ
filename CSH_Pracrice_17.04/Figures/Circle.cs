using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSH_Pracrice_17._04.Figures
{
    internal class Circle : Figure, ICostable
    {


        public double Radius { get; set; }

        public Circle(string color, string name, double radius) : base(color, name)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return 3.14 * (Radius * Radius);
        }

        public override double GetPerimeter()
        {
            return Radius * 3.14 * 2;
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                   "\nРадиус: " + Radius +
                   "\nПлощадь: " + GetArea() +
                   "\nПериметр: " + GetPerimeter();
        }
    }
}
