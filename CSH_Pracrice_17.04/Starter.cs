using CSH_Pracrice_17._04.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_Pracrice_17._04
{
    internal class Starter
    {
        public static Figure StartAdd()
        {
            Console.Write("Выберете фигуру: \n" +
                    "1 - Круг\n" +
                    "2 - Прямоугольник\n" +
                    "3 - Триугольник\n" +
                    "Выбор: ");
            int userChoise = Convert.ToInt32(Console.ReadLine());

            if (userChoise == 1)
            {
                Console.Write("Введите имя: \n");
                string name = Convert.ToString(Console.ReadLine());
                Console.Write("Введите цвет: \n");
                string color = Convert.ToString(Console.ReadLine());
                Console.Write("Введите радиус: \n");
                double r = Convert.ToDouble(Console.ReadLine());
                Circle circle = new Circle(color, name, r);
                return circle;
            }
            else if (userChoise == 2)
            {
                Console.Write("Введите имя: \n");
                string name = Convert.ToString(Console.ReadLine());
                Console.Write("Введите цвет: \n");
                string color = Convert.ToString(Console.ReadLine());
                Console.Write("Введите ширину: \n");
                double w = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите высоту: \n");
                double h = Convert.ToDouble(Console.ReadLine());
                Rectangle rectangle = new Rectangle(color, name, w, h);
                return rectangle;
            }
            else
            {
                Console.Write("Введите имя: \n");
                string name = Convert.ToString(Console.ReadLine());
                Console.Write("Введите цвет: \n");
                string color = Convert.ToString(Console.ReadLine());
                Console.Write("Введите сторону 1: \n");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите сторону 2: \n");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите сторону 3: \n");
                double c = Convert.ToDouble(Console.ReadLine());
                Triangle triangle = new Triangle(color, name, a, b, c);
                return triangle;
            }
        }


    }
}
