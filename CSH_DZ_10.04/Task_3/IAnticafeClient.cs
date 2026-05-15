using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_10._04.Task_3
{
    internal interface IAnticafeClient
    {
        static int CostHour = 100;

        double TotalCost();

        string Fio { get; set; }

        int CountHours { get; set; }
    }
}

