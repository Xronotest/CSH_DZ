using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_Practice_07._05.MediaItems
{
    internal class MusicAlbum : Media
    {        
        public string Executor { get; }
        public int Count { get; }

        public MusicAlbum(string title, string author, int yearPublished, string executor, int count) : base(title, author, yearPublished)
        {
            if (string.IsNullOrWhiteSpace(executor))
                throw new ArgumentException("Исполнитель не может быть пустым");

            if (count <= 0)
                throw new ArgumentException("Количество треков должно быть больше нуля");

            Executor = executor;
            Count = count;
        }



        public override string ToString()
        {
            return $"Музыкальный альбом | {Info()}, Исполнитель: {Executor}, Треков: {Count}";
        }
    }
}
