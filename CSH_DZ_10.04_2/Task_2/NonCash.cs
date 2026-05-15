using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_10._04_2.Task_2
{
    internal struct NonCash : IPayment
    {
        public static string name_ = "Безналичка";


        private int cardNumber_;
        private string date_;
        private string fio_;
        private int cvc_;

        public NonCash(int cardNumber, string date, string fio, int cvc, double sum)
        {
            cardNumber_ = cardNumber;
            date_ = date;
            fio_ = fio;
            cvc_ = cvc;
            Sum = sum;
        }


        public string GetName()
        {
            return name_;
        }
        public double Sum { get; set; }



        //public string GetInfo()
        //{
        //    return $"Сумма оплаты: {Sum}\n" +
        //        $"Способ оплаты: Безналичка\n" +
        //        $"Номер карты: {cardNumber_}" +
        //        $"Дата выдачи: {date_}" +
        //        $"ФИО владельца: {fio_}" +
        //        $"CVC код: {cvc_}";
        //}
    }
}
