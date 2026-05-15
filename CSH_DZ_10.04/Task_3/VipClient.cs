using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_10._04.Task_3
{
    internal class VipClient : IAnticafeClient, IConsoleOut
    {
        private static int costHour_ = 150;
        private string fio_ = " ";
        private int countHours_;

        public string Fio { get => fio_; set => fio_ = value; }

        public int CountHours { get => countHours_; set => countHours_ = value; }

        public VipClient(string fio, int countHours)
        {
            Fio = fio;
            CountHours = countHours;
        }

        public double TotalCost()
        {
            return CountHours * costHour_ + CountHours * costHour_ * 0.05;
        }

        public void Print()
        {
            Console.Write($"ФИО клиента: {Fio}\n" +
                $"Кол-во часов: {CountHours}\n" +
                $"Стоимость часа: {costHour_}\n");
        }
    }
}
