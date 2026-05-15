using CSH_DZ_10._04_2.Task_1;
using CSH_DZ_10._04_2.Task_2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSH_DZ_10._04_2
{
    internal class Starter
    {
        public static void StartFilm()
        {
            ShowFilm horror = new ShowFilm("Blitz", 1, "09.01", "22:00", 50, 150);
            ShowFilm comedy = new ShowFilm("1 day in Tailand", 3, "01.04", "13:00", 35, 120);
            ShowFilm triller = new ShowFilm("BiU", 2, "24.11", "15:20", 40, 140);
            ShowFilm mult = new ShowFilm("Sura", 1, "20.07", "11:00", 50, 170);
            ShowFilm document = new ShowFilm("Ukrali", 2, "30.02", "19:00", 40, 100);

            List<ShowFilm> showFilm = new List<ShowFilm>()
            {
                horror,
                comedy,
                triller, 
                mult,
                document
            };


            string name;
            int hall;
            string date;
            string time;
            int placeCount;
            int ticketPrice;

            do
            {
                Console.Write("Желаете добавить фильм?\n" +
                        "1 - Да\n" +
                        "Всё остальное - Нет\n" +
                        "Выбор: ");
                int choise = Convert.ToInt32(Console.ReadLine());
                if (choise == 1)
                {
                    Console.Write("Введите название: ");
                    name = Convert.ToString(Console.ReadLine());
                    Console.Write("Введите номер зала: ");
                    hall = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите дату: ");
                    date = Convert.ToString(Console.ReadLine());
                    Console.Write("Введите время: ");
                    time = Convert.ToString(Console.ReadLine());
                    Console.Write("Введите кол-во мест: ");
                    placeCount = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите стоимсоть билета: ");
                    ticketPrice = Convert.ToInt32(Console.ReadLine());
                    ShowFilm customFilm = new ShowFilm(name, hall, date, time, placeCount, ticketPrice);
                    showFilm.Add(customFilm);
                }
                else
                {
                    break;
                }

            } while (true);

            do
            {
                Console.Write("Желаете удалить фильм?\n" +
                        "1 - Да\n" +
                        "Всё остальное - Нет\n" +
                        "Выбор: ");
                int choise = Convert.ToInt32(Console.ReadLine());
                if (choise == 1)
                {
                    Console.Write("Введите название: ");
                    name = Convert.ToString(Console.ReadLine());
                    Console.Write("Введите дату: ");
                    date = Convert.ToString(Console.ReadLine());
                    Console.Write("Введите время: ");
                    time = Convert.ToString(Console.ReadLine());
                    foreach (ShowFilm films in showFilm)
                    {
                        if (
                                films.SeachInfo == 
                                "Название: " + name +
                                "Дата: " + date +
                                "Время: " + time
                            )
                        {
                            showFilm.Remove(films);
                        }
                    }
                }
                else
                {
                    break;
                }

            } while (true);

            showFilm.Sort((firstFilm, secondFilm) =>
                    firstFilm.GetName().CompareTo(secondFilm.GetName()));

            StringBuilder filmsInfo = new StringBuilder();
            foreach (ShowFilm films in showFilm)
            {
                filmsInfo.AppendLine(films.Info);
            }

            Console.WriteLine("Текущие фильмы: \n" +
                filmsInfo.ToString());

            Console.WriteLine("Выбор фильма ");
            Console.Write("Введите название: ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("Введите дату: ");
            date = Convert.ToString(Console.ReadLine());
            Console.Write("Введите время: ");
            time = Convert.ToString(Console.ReadLine());
            Console.Write("Сколько человек пришло на фильм: ");
            int peoples = Convert.ToInt32(Console.ReadLine());

            foreach (ShowFilm films in showFilm)
            {
                if (
                        films.SeachInfo ==
                        "Название: " + name +
                        "Дата: " + date +
                        "Время: " + time
                    )
                {
                    Console.WriteLine("Вабранный фильм: " +
                    films.Info + "\n" +
                    "Его заработок составил: " +
                    films.Selling(peoples) + "\n");
                }
            }


            
        }

        public static void StartPay()
        {
            Console.Write("Введите номер телефона покупателя: ");
            string phoneNumber = Convert.ToString(Console.ReadLine());
            Console.Write("Введите Способ оплаты: \n" +
                "1 - Наличка\n" +
                "2 - Безналичка\n" +
                "Выбор: ");
            int paymentMethod = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сумму покупки: ");
            double sumP = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сумму оплаты: ");
            double sum = Convert.ToInt32(Console.ReadLine());

            if (paymentMethod == 1)
            {

                Cash cash = new Cash(sum);
                Buy<Cash> buy = new Buy<Cash>(phoneNumber, cash, sumP);
                Console.Write(buy.Info() + "\n" + cash.GetChange(sumP));

            }
            else if (paymentMethod == 2)
            {
                Console.Write("Введите Номер карты: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Дату выдачи: ");
                string date = Convert.ToString(Console.ReadLine());
                Console.Write("Введите ФИО владельца: ");
                string fio = Convert.ToString(Console.ReadLine());
                Console.Write("Введите CVC код: ");
                int cvc = Convert.ToInt32(Console.ReadLine());
                NonCash nonCash = new NonCash(num, date, fio, cvc, sum);
                Buy<NonCash> buy = new Buy<NonCash>(phoneNumber, nonCash, sumP);
                Console.Write(buy.Info());
            }
        }

        public static void StartText()
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            Console.Write("Введите текст: ");
            string text = Console.ReadLine();

            string[] wordsArray = text
            .ToLower()
            .Split(" ");

            foreach (string word in wordsArray)
            {
                if (words.ContainsKey(word))
                {
                    words[word]++;
                }
                else
                {
                    words.Add(word, 1);
                }
            }

            Console.WriteLine();
            Console.WriteLine("{0,-15} {1,10}", "Слово", "Количество");
            Console.WriteLine(new string('-', 28));

            foreach (KeyValuePair<string, int> repetitions in words)
            {
                Console.WriteLine("{0,-15} {1,10}", repetitions.Key, repetitions.Value);
            }
        }
    }
}
