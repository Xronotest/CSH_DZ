using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_10._04.Task_2
{
    internal class Manager : ISalary, IConsoleOut
    {
        private int workDays_;

        public int WorkDays { get => workDays_; set => workDays_ = value; }

        public string Fio { get; set; }

        public Manager(int workDays, string fio)
        {
            WorkDays = workDays;
            Fio = fio;
        }

        public double CalculateSalary()
        {
            return workDays_ * 1000;
        }

        public void Print()
        {
            Console.Write($"ФИО: {Fio}\n" +
                $"Кол-во рабочих дней {WorkDays}\n" +
                $"Зарплата до вычета: {CalculateSalary()}\n");
        }
    }
}
