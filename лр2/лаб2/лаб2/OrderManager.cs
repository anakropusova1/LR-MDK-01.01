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
        public void PrintPriceList()
        {
            Console.WriteLine("Прайс-лист:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {names[i]} — {prices[i]} руб., {stock[i]} шт.");
            }
        }


        public void CollectOrder()
        {
            while (true)
            {
                int itemNum = ReadItemNumber();

                if (itemNum == 0)
                {
                    break;
                }

                int qty = ReadQuantity();
                orderQty[itemNum - 1] += qty;
            }
        }

        public bool ValidateOrder()
        {
            bool isValid = true;

            for (int i = 0; i < orderQty.Length; i++)
            {
                if (orderQty[i] > stock[i])
                {
                    Console.WriteLine($"Не хватило товара!!!! {names[i]} (нужно {orderQty[i]} шт., есть {stock[i]} шт.)");
                    isValid = false;
                }
            }

            return isValid;
        }

        public int CalculateTotal()
        {
            int total = 0;
            for (int i = 0; i < orderQty.Length; i++)
            {
                total += orderQty[i] * prices[i];
            }
            return total;
        }

        public void UpdateStock()
        {
            for (int i = 0; i < orderQty.Length; i++)
            {
                stock[i] -= orderQty[i];
            }
        }

        public void PrintStock()
        {
            Console.Write("Остатки на складе: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]} {stock[i]}");
                if (i < names.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }


    }
}

