using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_Pracrice_17._04
{
    internal abstract class Figure : ICostable
    {
        public string Color {  get; set; }

        public string Name { get; set; }

        public Figure(string color, string name)
        {
            Color = color;
            Name = name;
        }

        public Figure()
        {
            Color = string.Empty;
            Name = string.Empty;
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();

        public virtual string GetInfo() 
        {  return "Имя: " + Name + "\nЦвет: " + Color; }

        public double CalculateMaterialCost(double pricePerUnit)
        {
            return GetArea() * pricePerUnit;
        }

        public static bool operator <(Figure lso, Figure rso)
        {
            return lso.GetArea() < rso.GetArea();
        }

        public static bool operator >(Figure lso, Figure rso)
        {
            return lso.GetArea() > rso.GetArea();
        }

        public static double operator +(Figure lso, Figure rso)
        {
            return lso.GetPerimeter() + rso.GetPerimeter();
        }

        public static bool operator ==(Figure lso, Figure rso)
        {
            return Math.Abs(lso.GetArea() - rso.GetArea()) <= 0.01;
        }

        public static bool operator !=(Figure lso, Figure rso)
        {
            return !(lso == rso);
        }
    }
}
