using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_Pracrice_17._04
{
    internal class FigureStorage
    {
        private Figure[] _figures;

        private int Count {  get; set; }

        public FigureStorage() 
        { 
            _figures = new Figure[10];
            Count = 0;
        }

        public void AddFigure(Figure f)
        {
            if (Count < _figures.Length)
            {
                _figures[Count] = f;
                Count++;
            }
            else
            {
                Console.WriteLine("Массив полон");
            }
        }

        public Figure[] GetAll()
        {
            Figure[] figures = new Figure[Count];
            Array.Copy(_figures, figures, Count);
            return figures;
        }

        public double GetTotalArea()
        {
            double areaSum = 0;

            for (int i = 0; i < Count; i++)
            {
                areaSum += _figures[i].GetArea();
            }

            return areaSum;
        }
    }
}
