using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_10._04_2.Task_2
{
    internal interface IPayment
    {
        static string name_;

        double Sum {  get; set; }

        public string GetName();

        //string GetInfo();
    }
}
