using CSH_DZ_03._04.Figuress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04
{
    internal class Starter
    {
        public static GeometricFigure StartFigure()
        {
            GeometricFigure figure = new Triangle(1, 1, 1);
            Console.Write($"Какую фигуру вы хотите создать?\n" +
                $"0 - Составную\n" +
                $"1 - Треугольник\n" +
                $"2 - Квадрат\n" +
                $"3 - Ромб\n" +
                $"4 - Прямоугольник\n" +
                $"5 - Параллелограмм\n" +
                $"6 - Трапеция\n" +
                $"7 - Круг\n" +
                $"8 - Эллипс\n" +
                    "Выбор: ");
            int userChoise = Convert.ToInt32(Console.ReadLine());
            if (userChoise == 0)
            {
                figure = CustomFigure.Initialization();
                Console.WriteLine("Создана Составня фигура");
            }
            else if (userChoise == 1)
            {
                figure = Triangle.Initialization();
                Console.WriteLine("Создан Треугольник");
            }
            else if (userChoise == 2)
            {
                figure = Square.Initialization();
                Console.WriteLine("Создан Квадрат");
            }
            else if (userChoise == 3)
            {
                figure = Rhombus.Initialization();
                Console.WriteLine("Создан Ромб");
            }
            else if (userChoise == 4)
            {
                figure = Rectangle.Initialization();
                Console.WriteLine("Создан Прямоугольник");
            }
            else if (userChoise == 5)
            {
                figure = Parallelogram.Initialization();
                Console.WriteLine("Создан Параллелограмм");
            }
            else if (userChoise == 6)
            {
                figure = Trapezoid.Initialization();
                Console.WriteLine("Создана Трапеция");
            }
            else if (userChoise == 7)
            {
                figure = Circle.Initialization();
                Console.WriteLine("Создан Круг");
            }
            else if (userChoise == 8)
            {
                figure = Ellipse.Initialization();
                Console.WriteLine("Создан Эллипс");
            }
            return figure;
        }

        public static void StartHumans()
        {
            Console.Write($"Кого вы хотите создать: \n" +
                "0 - Человек\n" +
                "1 - Студент\n" +
                "2 - Преподаватель\n" +
                "Выбор: ");
            int humanChoise = Convert.ToInt32(Console.ReadLine());
            if (humanChoise == 0)
            {
                Console.Write("Введите Имя: ");
                string name = Convert.ToString(Console.ReadLine());
                Console.Write("Введите Возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Humans human = new Humans(name, age);
                Console.Write(human.Info());
            }
            else if (humanChoise == 1)
            {
                Console.Write("Введите Имя: ");
                string name = Convert.ToString(Console.ReadLine());
                Console.Write("Введите Возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Курс: ");
                int course = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Номер группы: ");
                int groupNo = Convert.ToInt32(Console.ReadLine());
                Student huaman = new Student(name, age, course, groupNo);
                Console.Write(huaman.Info());
            }
            else if (humanChoise == 2)
            {
                Console.Write("Введите Имя: ");
                string name = Convert.ToString(Console.ReadLine());
                Console.Write("Введите Возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Стаж работы: ");
                int exp = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Уровень квалификации: ");
                int lvl = Convert.ToInt32(Console.ReadLine());
                Teacher huaman = new Teacher(name, age, exp, lvl);
                Console.Write(huaman.Info());
                Console.Write($"Зарплата: {huaman.Salary()}");
            }
        }

        public static void StartTransport()
        {
            Console.Write($"Что вы хотите создать: \n" +
                "0 - Транспорт\n" +
                "1 - Автобус\n" +
                "2 - Троллейбус\n" +
                "Выбор: ");
            int transportChoise = Convert.ToInt32(Console.ReadLine());
            if (transportChoise == 0)
            {
                Console.Write("Введите Номер: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Вместимость: ");
                int count = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Скорость: ");
                int speed = Convert.ToInt32(Console.ReadLine());
                PublicTransport transport = new PublicTransport(num, count, speed);
                Console.Write(transport.Info());
            }
            else if (transportChoise == 1)
            {
                Console.Write("Введите Номер: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Вместимость: ");
                int count = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Скорость: ");
                int speed = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Вместимость бензобака: ");
                int fuel = Convert.ToInt32(Console.ReadLine());
                Bus transport = new Bus(num, count, speed, fuel);
                Console.Write(transport.Info());
                Console.Write($"Автобус проедет: {transport.Go()} км");
            }
            else if (transportChoise == 2)
            {
                Console.Write("Введите Номер: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Вместимость: ");
                int count = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Скорость: ");
                int speed = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Ёмкость аккумулятора: ");
                int acum = Convert.ToInt32(Console.ReadLine());
                Trolleybus transport = new Trolleybus(num, count, speed, acum);
                Console.Write(transport.Info());
                Console.Write($"Троллеёбус проедет: {transport.Go()} км");
            }
        }
    }
}
