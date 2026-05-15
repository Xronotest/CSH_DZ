using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_10._04.Task_1
{
    internal class ClassTo : IConverter, IConsoleOut
    {
        private string nameFrom_ = "Cel";
        private string nameTo_ = "Kel";

        public string NameFrom { get => nameFrom_; set => nameFrom_ = value; }

        public string NameTo { get => nameTo_; set => nameTo_ = value; }

        public ClassTo()
        {
        }

        public ClassTo(string nameFrom, string nameTo)
        {
            NameFrom = nameFrom;
            NameTo = nameTo;
        }

        public double Convert(double t)
        {
            return 273.15 + t;
        }

        public void Print()
        {
            Console.WriteLine($"Перевод из {NameFrom} в {NameTo}");
        }
    }
}
