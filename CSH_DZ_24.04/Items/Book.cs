using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_24._04.Items
{
    internal class Book : IInventoryItem
    {
        public string Name { get; }

        public decimal Price { get; }
        public int Quantity { get; set; }

        public CategoryInfo Category { get; } 

        public Book(string name, decimal price, int quantity, CategoryInfo category)
        {
            if (name == String.Empty || name == " ")
            {
                Console.WriteLine("Название не может быть пустым");
                name = "Unknown book";
            }

            if (price < 0)
            {
                Console.WriteLine("Цена не может быть отрицательной");
                price = 0;
            }

            if (quantity < 0)
            {
                Console.WriteLine("Количество не может быть отрицательным");
                quantity = 0;
            }

            Name = name;
            Price = price;
            Quantity = quantity;
            Category = category;
        }
    }
}
