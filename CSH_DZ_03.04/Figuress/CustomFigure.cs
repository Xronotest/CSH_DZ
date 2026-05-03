using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_03._04.Figuress
{
    internal class CustomFigure : GeometricFigure
    {
        private List<GeometricFigure> Figures;

        public CustomFigure()
        {
            Figures = new List<GeometricFigure>();
        }

        public static GeometricFigure Initialization()
        {
            CustomFigure customFigure = new CustomFigure();
            int loop = 1;
            int figureChoise;
            do
            {
                Console.Write($"Какую фигуру вы хотите Добавить?\n" +
                    $"1 - Треугольник\n" +
                    $"2 - Квадрат\n" +
                    $"3 - Ромб\n" +
                    $"4 - Прямоугольник\n" +
                    $"5 - Параллелограмм\n" +
                    $"6 - Трапеция\n" +
                    $"7 - Круг\n" +
                    $"8 - Эллипс\n" + 
                    "Выбор: ");
                figureChoise = Convert.ToInt32(Console.ReadLine());
                switch (figureChoise)
                {
                    case 1:
                        customFigure.AddFigure(Triangle.Initialization());
                        break;

                    case 2:
                        customFigure.AddFigure(Square.Initialization());
                        break;

                    case 3:
                        customFigure.AddFigure(Rhombus.Initialization());
                        break;

                    case 4:
                        customFigure.AddFigure(Rectangle.Initialization());
                        break;

                    case 5:
                        customFigure.AddFigure(Parallelogram.Initialization());
                        break;

                    case 6:
                        customFigure.AddFigure(Trapezoid.Initialization());
                        break;

                    case 7:
                        customFigure.AddFigure(Circle.Initialization());
                        break;

                    case 8:
                        customFigure.AddFigure(Ellipse.Initialization());
                        break;
                }
                Console.Write($"Желаете добавить ещё фигур?\n" +
                    $"0 - Нет\n" +
                    $"1 - Да\n" +
                    "Выбор: ");
                int exit = Convert.ToInt32(Console.ReadLine());
                if (exit == 0)
                {
                    loop = 0;
                }
            }
            while (loop != 0);

            return customFigure;
        }

        public void AddFigure(GeometricFigure Figure)
        {
            Figures.Add(Figure);
        }

        public override double S_Math()
        {
            double S = 0;

            foreach (GeometricFigure Figure in Figures)
            {
                S += Figure.S_Math();
            }

            return S;
        }

        public override double P_Math()
        {
            double P = 0;

            foreach (GeometricFigure Figure in Figures)
            {
                P += Figure.P_Math();
            }

            return P;
        }
    }
}
