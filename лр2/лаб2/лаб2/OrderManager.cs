using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб2
{
    internal class OrderManager
    {
        private string[] names = { "хлеб", "молоко", "сыр", "колбаса", "масло",
                                   "яйца", "кефир", "творог", "курица", "яблоки" };
        private int[] prices = { 45, 80, 350, 420, 120,
                                 90, 75, 150, 280, 110 };
        private int[] stock = { 30, 25, 12, 8, 15,
                                40, 20, 10, 15, 50 };

        private int[] orderQty;

        public OrderManager()
        {
            orderQty = new int[names.Length];
        }

    }
}
