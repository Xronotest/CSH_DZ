using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_10._04.Task_1
{
    internal class ClassFrom : IConverter, IConsoleOut
    {
        private string nameFrom_ = "Cel";
        private string nameTo_ = "For";

        public string NameFrom { get => nameFrom_; set => nameFrom_ = value; }

        public string NameTo { get => nameTo_; set => nameTo_ = value; }

        public ClassFrom()
        {
        }
        public ClassFrom(string nameFrom, string nameTo) 
        {
            NameFrom = nameFrom;
            NameTo = nameTo;
        }

        public double Convert(double t)
        {
            return 1.8 * t + 32;
        }

        public void Print()
        {
            Console.WriteLine($"Перевод из {NameFrom} в {NameTo}");
        }
    }
}
