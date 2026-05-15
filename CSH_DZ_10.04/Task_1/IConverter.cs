using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_10._04.Task_1
{
    internal interface IConverter
    {
        double Convert(double t);

        string NameFrom { get; set; }

        public string NameTo { get; set; }

    }
}
