using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_10._04.Task_2
{
    internal class Buhaltery
    {
        public static double CalculateTaxes(ISalary why, int workDays)
        {
            return why.CalculateSalary() * 0.13;
        }
    }
}
