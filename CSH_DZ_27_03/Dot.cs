using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_27_03
{
    internal class Dot
    {        
        private int X;
        private int Y;
        private int Z;

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

        public void PrintCoords()
        {
            Console.WriteLine($"Текущие координаты: {X}, {Y}, {Z}");
        }

        public void MoveBy(int dx, int dy, int dz)
        {
            Console.WriteLine(" ");
            X += dx;
            Y += dy;
            Z += dz;
            Console.WriteLine($"Новые координаты координаты: {X}, {Y}, {Z}");
        }

    }
}
