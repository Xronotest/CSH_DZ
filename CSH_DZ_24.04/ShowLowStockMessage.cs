using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSH_DZ_24._04
{
    internal class ShowLowStockMessage
    {

        public static void Message(string itemName, int currentQuantity)
        {
            Console.WriteLine($"Мало товара на складе: {itemName}, осталось: {currentQuantity}");
        }
    }
}
