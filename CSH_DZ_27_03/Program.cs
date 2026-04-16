namespace CSH_DZ_27_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int userChoise = Convert.ToInt32(Console.ReadLine());

            if (userChoise == 1)
            {
                Console.Write("Введите текущий X: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите текущий Y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите текущий Z: ");
                int z = Convert.ToInt32(Console.ReadLine());
                Dot dot = new Dot(x,y,z);
                Dot.PrintCoords();
                Console.Write("Введите передвидение по X: ");
                int dx = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите передвидение по Y: ");
                int dy = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите передвидение по Z: ");
                int dz = Convert.ToInt32(Console.ReadLine());
                Dot.MoveBy(dx, dy, dz);
            }

            else if (userChoise == 2)
            {
                Console.Write("Введите Фамилию: ");
                String surname = Console.ReadLine();
                Console.Write("Введите Имя: ");
                String name = Console.ReadLine();
                Console.Write("Введите Отчество: ");
                String patronymic = Console.ReadLine();
                Console.Write("Введите возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());
                User user = new User(surname, name, patronymic, age);
                User.Fio(user);
            }

            else if (userChoise == 3)
            {
                Console.Write("Введите Модель: ");
                String model = Console.ReadLine();
                Console.Write("Введите Тактоую частоту процессора: ");
                double processorGhz = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите Объём оперативной памяти: ");
                int ram = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Объём памяти: ");
                int memory = Convert.ToInt32(Console.ReadLine());
                PC pc = new PC(model,processorGhz,ram,memory);
                PC.Info(pc);
            }

            else if (userChoise == 4)
            {
                Console.Write("Введите Модель: ");
                String model = Console.ReadLine();
                Console.Write("Введите Тактоую частоту процессора: ");
                double processorGhz = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите Объём оперативной памяти: ");
                int ram = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Объём памяти: ");
                int memory = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Вес: ");
                int weight = Convert.ToInt32(Console.ReadLine());
                Laptop laptop = new Laptop(model, processorGhz, ram, memory, weight);
                Laptop.Info(laptop);
            }


            else if (userChoise == 5)
            {
                Console.Write("Выберите ариант решения (1 - Features, 2 - Method): ");
                int variantChoise = Convert.ToInt32(Console.ReadLine());

                if (variantChoise == 1)
                {
                    Console.Write("Введите Название: ");
                    String name = Console.ReadLine();
                    Console.Write("Введите Автора: ");
                    String author = Console.ReadLine();
                    Console.Write("Введите Год выпуска: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите Объём листов: ");
                    int lists = Convert.ToInt32(Console.ReadLine());
                    Features book = new Features(name, author, year, lists);
                    Console.WriteLine(book.Info);
                }
                else
                {
                    if (variantChoise == 2)
                    {
                        Console.Write("Введите Название: ");
                        String name = Console.ReadLine();
                        Console.Write("Введите Автора: ");
                        String author = Console.ReadLine();
                        Console.Write("Введите Год выпуска: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите Объём листов: ");
                        int lists = Convert.ToInt32(Console.ReadLine());
                        Method book = new Method(name, author, year,lists);
                        Method.Info(book);
                    }
                }
            }
        }
    }
}
