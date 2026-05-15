using CSH_DZ_24._04.Items;

namespace CSH_DZ_24._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WarehouseManager<Book> storage = new WarehouseManager<Book>();

            CategoryInfo bookCategory = new CategoryInfo("Books", 1);
            Book book = new Book("Book", 1000, 10, bookCategory);

            storage.Add(book);

            storage.OnLowStock += ShowLowStockMessage.Message;

            storage.UpdateQuantity("Book", 5);

            storage.OnLowStock -= ShowLowStockMessage.Message;

            storage.UpdateQuantity("Book", 3);
        }
    }
}
