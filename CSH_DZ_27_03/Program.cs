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
                dot.PrintCoords();
                Console.Write("Введите передвидение по X: ");
                int dx = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите передвидение по Y: ");
                int dy = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите передвидение по Z: ");
                int dz = Convert.ToInt32(Console.ReadLine());
                dot.MoveBy(dx, dy, dz);
            }

            else if (userChoise == 2)
            {
                Console.Write("Введите Фамилию: ");
                string surname = Console.ReadLine();
                Console.Write("Введите Имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите Отчество: ");
                string patronymic = Console.ReadLine();
                Console.Write("Введите возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());
                User user = new User(surname, name, patronymic, age);
                user.Fio(user);
            }

            else if (userChoise == 3)
            {
                Console.Write("Введите Модель: ");
                string model = Console.ReadLine();
                Console.Write("Введите Тактоую частоту процессора: ");
                double processorGhz = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите Объём оперативной памяти: ");
                int ram = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Объём памяти: ");
                int memory = Convert.ToInt32(Console.ReadLine());
                PC pc = new PC(model,processorGhz,ram,memory);
                pc.Info(pc);
            }

            else if (userChoise == 4)
            {
                Console.Write("Введите Модель: ");
                string model = Console.ReadLine();
                Console.Write("Введите Тактоую частоту процессора: ");
                double processorGhz = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите Объём оперативной памяти: ");
                int ram = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Объём памяти: ");
                int memory = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите Вес: ");
                int weight = Convert.ToInt32(Console.ReadLine());
                Laptop laptop = new Laptop(model, processorGhz, ram, memory, weight);
                laptop.Info(laptop);
            }


            else if (userChoise == 5)
            {
                Console.Write("Выберите ариант решения (1 - Features, 2 - Method): ");
                int variantChoise = Convert.ToInt32(Console.ReadLine());

                if (variantChoise == 1)
                {

                    Console.Write("Введите Автора: ");
                    string author = Console.ReadLine();
                    Console.Write("Введите Год выпуска: ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите Объём листов: ");
                    int lists = Convert.ToInt32(Console.ReadLine());
                    
                    Features book = new Features(author, year, lists);
                    Console.Write("Введите Название: ");
                    book.Name = Console.ReadLine();
                    Console.Write("Введите Издательсвто: ");
                    book.Publisher = Console.ReadLine();
                    Console.WriteLine(book.Info);
                }
                else
                {
                    if (variantChoise == 2)
                    {

                        Console.Write("Введите Автора: ");
                        string author = Console.ReadLine();
                        Console.Write("Введите Год выпуска: ");
                        int year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите Объём листов: ");
                        int lists = Convert.ToInt32(Console.ReadLine());

                        Method book = new Method(author, year, lists);
                        Console.Write("Введите Название: ");
                        book.SetName(Console.ReadLine());
                        Console.Write("Введите Издательсвто: ");
                        book.SetPublisher(Console.ReadLine());
                        book.Info(book);
                    }
                }
            }
        }
    }
}
