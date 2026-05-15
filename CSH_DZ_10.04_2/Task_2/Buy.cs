using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_10._04_2.Task_2
{
    internal class Buy<TPayment>
    where TPayment : IPayment
    {
        private string phoneNumber_;
        private TPayment paymentMethod_;
        private double sum_;

        public Buy(string phoneNumber, TPayment payment, double sum)
        {
            phoneNumber_ = phoneNumber;
            paymentMethod_ = payment;
            sum_ = sum;
        }

        public string Info()
        {
            return $"Номер телефона покупателя: {phoneNumber_}\n" +
                $"Способ оплаты: {paymentMethod_.GetName()}\n" +
                $"Сумма покупки: {sum_}\n" +
                $"Сумма оплаты: {paymentMethod_.Sum}\n";
        }

        public double GetSum()
        {
            return sum_;
        }


    }
}
