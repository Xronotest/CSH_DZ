using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_Practice_07._05
{
    internal class Library<T> : IMediaManager<T> where T : Media
    {
        private List<T> _items = new();
        private Dictionary<string, T> _itemsByTitle = new Dictionary<string, T>();

        public void Add(T item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (_itemsByTitle.ContainsKey(item.Title))
                throw new DuplicateMediaException($"Медиа с названием '{item.Title}' уже существует");

            _items.Add(item);
            _itemsByTitle.Add(item.Title, item);
        }

        public bool Remove(string title)
        {
            var item = FindByTitle(title);

            _items.Remove(item);
            _itemsByTitle.Remove(item.Title);

            return true;
        }

        public T FindByTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Название не может быть пустым");

            if (!_itemsByTitle.TryGetValue(title, out T item))
                throw new MediaNotFoundException($"Медиа с названием '{title}' не найдено");

            return item;
        }

        public IEnumerable<T> FilterByYear(int year)
        {
            return _items.Where(item => item.YearPublished == year);
        }

        public IEnumerable<T> GetAllAvailable()
        {
            return _items.Where(item => item.IsAvailable);
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public IEnumerable<T> GetUnavailable()
        {
            return _items.Where(item => !item.IsAvailable);
        }

        public void AvailebleMedia(string title)
        {
            FindByTitle(title).Availeble();
        }

        public void ReturnMedia(string title)
        {
            FindByTitle(title).Return();
        }

        public void PrintAll()
        {
            if (!_items.Any())
            {
                Console.WriteLine("Библиотека пуста");
                return;
            }

            foreach (T item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
