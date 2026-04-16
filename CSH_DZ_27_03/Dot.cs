using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_27_03
{
    internal class Dot
    {        
        static private int X;
        static private int Y;
        static private int Z;

        public Dot() 
        { 
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Dot(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        static public void PrintCoords()
        {
            Console.WriteLine($"Текущие координаты: {X}, {Y}, {Z}");
        }

        static public void MoveBy(int dx, int dy, int dz)
        {
            Console.WriteLine(" ");
            X += dx;
            Y += dy;
            Z += dz;
            Console.WriteLine($"Новые координаты координаты: {X}, {Y}, {Z}");
        }

    }
}
