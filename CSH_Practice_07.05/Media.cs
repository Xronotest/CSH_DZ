using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_Practice_07._05
{
    internal class Media
    {
        public string Title { get; }
        public string Author { get; }
        public int YearPublished { get; }
        public bool IsAvailable { get; set; }
        public Media(string title, string author, int yearPublished)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Название не может быть пустым");

            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("Автор не может быть пустым");

            if (yearPublished <= 0)
                throw new ArgumentException("Год указан неверно");

            Title = title;
            Author = author;
            YearPublished = yearPublished;
            IsAvailable = true;
        }


        public void Availeble()
        {
            if (!IsAvailable)
                throw new MediaException($"{Title} не доступно");

            IsAvailable = false;
        }

        public void Return()
        {
            if (IsAvailable)
                throw new MediaException($"{Title} доступно");

            IsAvailable = true;
        }

        protected string Info()
        {
            string available;
            if (IsAvailable)
            {
                available = "Да";
            }
            else
            {
                available = "Нет";
            }
          
            return $"Название: {Title}, Автор: {Author}, Год: {YearPublished}, Доступно: {available}";
        }

    }
}
