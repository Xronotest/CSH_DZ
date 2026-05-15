using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_10._04.Task_2
{
    internal interface ISalary
    {
        double CalculateSalary();

        string Fio {  get; set; }

        int WorkDays { get; set; }
    }
}
