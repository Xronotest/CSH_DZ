using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_Practice_07._05.MediaItems
{
    internal class Movie : Media
    {        
        public int Duration { get; }
        public string Director { get; }
        public Movie(string title, string author, int yearPublished, int duration, string director) : base(title, author, yearPublished)
        {
            if (duration <= 0)
                throw new ArgumentException("Длительность должна быть больше нуля");

            if (string.IsNullOrWhiteSpace(director))
                throw new ArgumentException("Режиссер не может быть пустым");

            Duration = duration;
            Director = director;
        }



        public override string ToString()
        {
            return $"Фильм | {Info()}, Длительность: {Duration} мин, Режиссер: {Director}";
        }
    }
}
