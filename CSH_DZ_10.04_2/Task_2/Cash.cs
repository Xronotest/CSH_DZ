using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_10._04_2.Task_2
{
    internal struct Cash : IPayment
    {
        public static string name_ = "Наличка";

        private double change_;
        public double Sum { get; set; }

        public Cash(double sum)
        {
            Sum = sum;
        }


        public double GetChange(double sumP)
        {
            change_ = Sum - sumP;
            if (change_ < 0)
            {
                return 0;
            }
            return change_;
        }

        public string GetName()
        {
            return name_;
        }

        //public string GetInfo()
        //{
        //    return $"Сумма оплаты: {Sum}\n" +
        //        $"Способ оплаты: Наличка";
        //}
    }
}
