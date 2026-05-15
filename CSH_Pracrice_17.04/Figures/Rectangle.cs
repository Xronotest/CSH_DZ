using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_Pracrice_17._04.Figures
{
    internal class Rectangle : Figure, ICostable
    {


        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(string color, string name, double width, double height) : base(color, name)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return (Width + Height) * 2;
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                   "\nШирина: " + Width +
                   "\nВысота: " + Height +
                   "\nПлощадь: " + GetArea() +
                   "\nПериметр: " + GetPerimeter();
        }
    }
}
