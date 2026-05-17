using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_Practice_07._05.MediaItems
{
    internal class Book : Media
    {
        public int PageCount { get; }
        public string Category { get; }

        public Book(string title, string author, int yearPublished, int pageCount, string category) : base(title, author, yearPublished)
        {
            if (pageCount <= 0)
                throw new ArgumentException("Количество страниц должно быть больше нуля");

            if (string.IsNullOrWhiteSpace(category))
                throw new ArgumentException("Жанр не может быть пустым");

            PageCount = pageCount;
            Category = category;
        }



        public override string ToString()
        {
            return $"Книга | {Info()}, Страниц: {PageCount}, Жанр: {Category}";
        }
    }
}
