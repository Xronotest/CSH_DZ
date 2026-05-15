using CSH_DZ_10._04.Task_1;
using CSH_DZ_10._04.Task_2;
using CSH_DZ_10._04.Task_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_10._04
{
    internal class Starter
    {
        public static void StartGradus()
        {
            Console.Write("Использовать значения по умолчанию?\n" +
                "1 - Да\n" +
                "2 - Нет\n" +
                "Выбор: ");
            int choise = Convert.ToInt32(Console.ReadLine());
            if (choise == 1)
            {
                ClassFrom classFrom = new ClassFrom();
                ClassTo classTo = new ClassTo();

                Console.Write("Введите температуру в цельсиях: ");
                double t = Convert.ToDouble(Console.ReadLine());
                classFrom.Print();
                Console.Write($"Результат: {classFrom.Convert(t)}\n");

                classTo.Print();
                Console.Write($"Результат: {classTo.Convert(t)}\n");
            }
            else if (choise == 2)
            {
                Console.Write("Введите название шкалы, из которой происходит конвертация для 1-го класса: ");
                string nameFrom = Convert.ToString(Console.ReadLine());
                Console.Write("Введите название шкалы, в которую происходит конвертация для 1-го класса: ");
                string nameTo = Convert.ToString(Console.ReadLine());
                ClassFrom classFrom = new ClassFrom(nameFrom, nameTo);

                Console.Write("Введите название шкалы, из которой происходит конвертация для 2-го класса: ");
                nameFrom = Convert.ToString(Console.ReadLine());
                Console.Write("Введите название шкалы, в которую происходит конвертация для 2-го класса: ");
                nameTo = Convert.ToString(Console.ReadLine());
                ClassTo classTo = new ClassTo(nameFrom, nameTo);

                Console.Write("Введите температуру: ");
                double t = Convert.ToDouble(Console.ReadLine());
                classFrom.Print();
                Console.Write($"Результат: {classFrom.Convert(t)}\n");

                classTo.Print();
                Console.Write($"Результат: {classTo.Convert(t)} \n");
            }
        }

        public static void StartSalary()
        {
            Console.Write("Введите ФИО манеджера: ");
            string fio = Convert.ToString(Console.ReadLine());
            Console.Write("Введите его кол-во рабочих дней: ");
            int workDays = Convert.ToInt32(Console.ReadLine());
            Manager manager = new Manager(workDays, fio);

            Console.Write("Введите ФИО главы отдела: ");
            fio = Convert.ToString(Console.ReadLine());
            Console.Write("Введите его кол-во рабочих дней: ");
            workDays = Convert.ToInt32(Console.ReadLine());
            Boss boss = new Boss(workDays, fio);

            manager.Print();
            Console.WriteLine($"Зарплата менеджера после вычета: {manager.CalculateSalary() - Buhaltery.CalculateTaxes(manager, manager.WorkDays)}");

            boss.Print();
            Console.WriteLine($"Зарплата главы отдела после вычета: {boss.CalculateSalary() - Buhaltery.CalculateTaxes(boss, boss.WorkDays)}");
        }

        public static void StartAnticafe()
        {
            Console.Write("Введите ФИО стандартного клиента: ");
            string fio = Convert.ToString(Console.ReadLine());
            Console.Write("Введите кол-во часов: ");
            int countHours = Convert.ToInt32(Console.ReadLine());
            StandardClient standardClient = new StandardClient(fio, countHours);

            Console.Write("Введите ФИО VIP клиента: ");
            fio = Convert.ToString(Console.ReadLine());
            Console.Write("Введите кол-во часов: ");
            countHours = Convert.ToInt32(Console.ReadLine());
            VipClient vipClient = new VipClient(fio, countHours);

            standardClient.Print();
            Console.WriteLine($"Полная стоимость посещения: {standardClient.TotalCost()}");

            vipClient.Print();
            Console.WriteLine($"Полная стоимость посещения VIP клиента: {vipClient.TotalCost()}");
        }
    }
}
