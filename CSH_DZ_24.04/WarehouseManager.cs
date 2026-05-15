using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_24._04
{
    internal class WarehouseManager<T>
        where T : class, IInventoryItem
    {
        private Dictionary<string, T> items = new Dictionary<string, T>();

        public void Add(T item)
        {
            if (item == null)
            {
                Console.WriteLine("Товар не может быть пустым");
                return;
            }

            if (items.ContainsKey(item.Name))
            {
                Console.WriteLine("Товар с таким именем уже есть на складе");
                return;
            }

            items.Add(item.Name, item);
        }

        public void Remove(string name)
        {
            if (!items.ContainsKey(name))
            {
                Console.WriteLine("Товар не найден");
                return;
            }

            items.Remove(name);
        }

        public void UpdateQuantity(string name, int newQuantity)
        {
            if (newQuantity < 0)
            {
                Console.WriteLine("Количество не может быть отрицательным");
                return;
            }

            if (!items.ContainsKey(name))
            {
                Console.WriteLine("Товар не найден");
                return;
            }

            items[name].Quantity = newQuantity; // Вот ксатати взаимодействие через имя

            if (newQuantity <= 5)
            {
                OnLowStock?.Invoke(name, newQuantity);
            }
        }

        public IEnumerable<T> GetLowStockItems(int threshold)
        {
            return from item in items.Values
                   where item.Quantity <= threshold
                   orderby item.Name
                   select item;
        }

        public IEnumerable<IGrouping<string, T>> GetItemsByCategory()
        {
            return from item in items.Values
                   group item by item.Category.Name;


        }

        public decimal GetTotalInventoryValue()
        {
            return (from item in items.Values
                    let sum = item.Price * item.Quantity
                    select sum).Sum();
        }

        public IEnumerable<string> GetTopCategoriesByValue(int count)
        {
            return (from item in items.Values
                    group item by item.Category.Name into categoryGroup
                    let totalValue = categoryGroup.Sum(item => item.Price * item.Quantity)
                    orderby totalValue descending
                    select categoryGroup.Key).Take(count);

            //return items.Values
            //        .GroupBy(item => item.Category.Name)
            //        .Select(group => new
            //        {
            //            CategoryName = group.Key,
            //            TotalValue = group.Sum(item => item.Price * item.Quantity)
            //        })
            //        .OrderByDescending(category => category.TotalValue)
            //        .Take(count)
            //        .Select(category => category.CategoryName);
        }

        public event LowStockAlertHandler OnLowStock;
    }
    //Взаимодействовать с товарами можно через имя
}
