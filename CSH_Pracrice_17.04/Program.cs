namespace CSH_Pracrice_17._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FigureStorage figureStorage = new FigureStorage();
            do
            {
                Console.Write("Выберете действие: \n" +
                    "1 - Добавить фигуру\n" +
                    "2 - Показать все фигуры\n" +
                    "3 - Сравнить две фигуры\n" +
                    "4 - Посчитать стоимость материалов\n" +
                    "0 - Выход\n" +
                    "Выбор: ");
                int userChoise = Convert.ToInt32(Console.ReadLine());

                if (userChoise == 1)
                {
                    figureStorage.AddFigure(Starter.StartAdd());
                }
                else if (userChoise == 2)
                {
                    Figure[] figures = figureStorage.GetAll();
                    for (int i = 0; i < figures.Length; i++)
                    {
                        Console.WriteLine(figures[i].GetInfo() + "\n");
                    }
                }
                else if (userChoise == 3)
                {
                    Console.Write("Введите индекс 1 фигуры: ");
                    int figure_1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите индекс 2 фигуры: ");
                    int figure_2 = Convert.ToInt32(Console.ReadLine());

                    Figure[] figures = figureStorage.GetAll();
                    if (figures[figure_1] > figures[figure_2])
                    {
                        Console.WriteLine(figures[figure_1].GetInfo() + "\n Больше чем \n" + figures[figure_2].GetInfo());
                    }
                    else if (figures[figure_1] < figures[figure_2])
                    {
                        Console.WriteLine(figures[figure_2].GetInfo() + "\n Больше чем \n" + figures[figure_1].GetInfo());
                    }
                    else
                    {
                        Console.WriteLine("Они равны");
                    }
                }
                else if (userChoise == 4)
                {
                    Console.Write("Введите цену за кв.м: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Figure[] figures = figureStorage.GetAll();
                    for (int i = 0; i < figures.Length; i++)
                    {
                        Console.WriteLine(figures[i].GetInfo() + "\n Стоимсоть: " + figures[i].CalculateMaterialCost(price));
                    }
                }
                else if (userChoise == 0)
                {
                    break;
                }

            } while (true);

        }
    }
}
