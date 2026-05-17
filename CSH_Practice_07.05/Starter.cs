using CSH_Practice_07._05.MediaItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_Practice_07._05
{
    internal class Starter
    {
        public static void Start()
        {
            Library<Book> books = new Library<Book>();
            Library<Movie> movies = new Library<Movie>();
            Library<MusicAlbum> albums = new Library<MusicAlbum>();

            do
            {
                try
                {
                    Console.Write("Выберите действие:\n" +
                        "1 - Добавить медиа\n" +
                        "2 - Показать все медиа\n" +
                        "3 - Найти медиа по названию\n" +
                        "4 - Удалить медиа\n" +
                        "5 - Выдать медиа\n" +
                        "6 - Вернуть медиа\n" +
                        "7 - Фильтр по году\n" +
                        "8 - Показать доступные медиа\n" +
                        "9 - Показать недоступные медиа\n" +
                        "10 - Книги после года\n" +
                        "11 - Фильмы по длительности\n" +
                        "0 - Выход\n" +
                        "Выбор: ");

                    int userChoise = Convert.ToInt32(Console.ReadLine());

                    if (userChoise == 1)
                    {
                        Console.Write("Выберите тип медиа:\n" +
                            "1 - Книга\n" +
                            "2 - Фильм\n" +
                            "3 - Музыкальный альбом\n" +
                            "Выбор: ");

                        int type = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите название: ");
                        string title = Convert.ToString(Console.ReadLine());

                        Console.Write("Введите автора: ");
                        string author = Convert.ToString(Console.ReadLine());

                        Console.Write("Введите год выпуска: ");
                        int year = Convert.ToInt32(Console.ReadLine());

                        if (type == 1)
                        {
                            Console.Write("Введите количество страниц: ");
                            int pages = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Введите жанр: ");
                            string category = Convert.ToString(Console.ReadLine());

                            books.Add(new Book(title, author, year, pages, category));
                        }
                        else if (type == 2)
                        {
                            Console.Write("Введите длительность в минутах: ");
                            int duration = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Введите режиссера: ");
                            string director = Convert.ToString(Console.ReadLine());

                            movies.Add(new Movie(title, author, year, duration, director));
                        }
                        else if (type == 3)
                        {
                            Console.Write("Введите исполнителя: ");
                            string executor = Convert.ToString(Console.ReadLine());

                            Console.Write("Введите количество треков: ");
                            int count = Convert.ToInt32(Console.ReadLine());

                            albums.Add(new MusicAlbum(title, author, year, executor, count));
                        }

                        Console.WriteLine("Медиа добавлено");
                    }
                    else if (userChoise == 2)
                    {
                        books.PrintAll();
                        movies.PrintAll();
                        albums.PrintAll();
                    }
                    else if (userChoise == 3)
                    {
                        Console.Write("Выберите тип медиа:\n" +
                            "1 - Книга\n" +
                            "2 - Фильм\n" +
                            "3 - Музыкальный альбом\n" +
                            "Выбор: ");

                        int type = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите название: ");
                        string title = Convert.ToString(Console.ReadLine());

                        if (type == 1) Console.WriteLine(books.FindByTitle(title));
                        else if (type == 2) Console.WriteLine(movies.FindByTitle(title));
                        else if (type == 3) Console.WriteLine(albums.FindByTitle(title));
                    }
                    else if (userChoise == 4)
                    {
                        Console.Write("Выберите тип медиа:\n" +
                            "1 - Книга\n" +
                            "2 - Фильм\n" +
                            "3 - Музыкальный альбом\n" +
                            "Выбор: ");

                        int type = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите название: ");
                        string title = Convert.ToString(Console.ReadLine());

                        if (type == 1) books.Remove(title);
                        else if (type == 2) movies.Remove(title);
                        else if (type == 3) albums.Remove(title);

                        Console.WriteLine("Медиа удалено");
                    }
                    else if (userChoise == 5)
                    {
                        Console.Write("Выберите тип медиа:\n" +
                            "1 - Книга\n" +
                            "2 - Фильм\n" +
                            "3 - Музыкальный альбом\n" +
                            "Выбор: ");

                        int type = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите название: ");
                        string title = Convert.ToString(Console.ReadLine());

                        if (type == 1) books.AvailebleMedia(title);
                        else if (type == 2) movies.AvailebleMedia(title);
                        else if (type == 3) albums.AvailebleMedia(title);

                        Console.WriteLine("Медиа выдано");
                    }
                    else if (userChoise == 6)
                    {
                        Console.Write("Выберите тип медиа:\n" +
                            "1 - Книга\n" +
                            "2 - Фильм\n" +
                            "3 - Музыкальный альбом\n" +
                            "Выбор: ");

                        int type = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите название: ");
                        string title = Convert.ToString(Console.ReadLine());

                        if (type == 1) books.ReturnMedia(title);
                        else if (type == 2) movies.ReturnMedia(title);
                        else if (type == 3) albums.ReturnMedia(title);

                        Console.WriteLine("Медиа возвращено");
                    }
                    else if (userChoise == 7)
                    {
                        Console.Write("Выберите тип медиа:\n" +
                            "1 - Книга\n" +
                            "2 - Фильм\n" +
                            "3 - Музыкальный альбом\n" +
                            "Выбор: ");

                        int type = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Введите год: ");
                        int year = Convert.ToInt32(Console.ReadLine());

                        bool isEmpty = true;

                        if (type == 1)
                        {
                            foreach (Book book in books.FilterByYear(year))
                            {
                                Console.WriteLine(book);
                                isEmpty = false;
                            }
                        }
                        else if (type == 2)
                        {
                            foreach (Movie movie in movies.FilterByYear(year))
                            {
                                Console.WriteLine(movie);
                                isEmpty = false;
                            }
                        }
                        else if (type == 3)
                        {
                            foreach (MusicAlbum album in albums.FilterByYear(year))
                            {
                                Console.WriteLine(album);
                                isEmpty = false;
                            }
                        }

                        if (isEmpty) Console.WriteLine("Ничего не найдено");
                    }
                    else if (userChoise == 8)
                    {
                        bool isEmpty = true;

                        foreach (Book book in books.GetAllAvailable())
                        {
                            Console.WriteLine(book);
                            isEmpty = false;
                        }

                        foreach (Movie movie in movies.GetAllAvailable())
                        {
                            Console.WriteLine(movie);
                            isEmpty = false;
                        }

                        foreach (MusicAlbum album in albums.GetAllAvailable())
                        {
                            Console.WriteLine(album);
                            isEmpty = false;
                        }

                        if (isEmpty) Console.WriteLine("Ничего не найдено");
                    }
                    else if (userChoise == 9)
                    {
                        bool isEmpty = true;

                        foreach (Book book in books.GetUnavailable())
                        {
                            Console.WriteLine(book);
                            isEmpty = false;
                        }

                        foreach (Movie movie in movies.GetUnavailable())
                        {
                            Console.WriteLine(movie);
                            isEmpty = false;
                        }

                        foreach (MusicAlbum album in albums.GetUnavailable())
                        {
                            Console.WriteLine(album);
                            isEmpty = false;
                        }

                        if (isEmpty) Console.WriteLine("Ничего не найдено");
                    }
                    else if (userChoise == 10)
                    {
                        Console.Write("Введите год: ");
                        int year = Convert.ToInt32(Console.ReadLine());

                        bool isEmpty = true;

                        foreach (Book book in books.BooksAfter(year))
                        {
                            Console.WriteLine(book);
                            isEmpty = false;
                        }

                        if (isEmpty) Console.WriteLine("Ничего не найдено");
                    }
                    else if (userChoise == 11)
                    {
                        bool isEmpty = true;

                        foreach (Movie movie in movies.MovieSortDuration())
                        {
                            Console.WriteLine(movie);
                            isEmpty = false;
                        }

                        if (isEmpty) Console.WriteLine("Ничего не найдено");
                    }
                    else if (userChoise == 0)
                    {
                        break;
                    }
                }
                catch (MediaException ex)
                {
                    Console.WriteLine($"Ошибка библиотеки: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка ввода: {ex.Message}");
                }

                Console.WriteLine();
            } while (true);
        }
    }
}
