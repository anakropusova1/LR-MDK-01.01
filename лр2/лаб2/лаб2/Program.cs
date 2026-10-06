using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderManager manager = new OrderManager();
            manager.PrintPriceList();
            manager.CollectOrder();

            if (manager.ValidateOrder())
            {
                int totalCost = manager.CalculateTotal();
                manager.UpdateStock();
                Console.WriteLine($"Стоимость заказа: {totalCost} руб.");
            }

            manager.PrintStock();
        }
    }
}
