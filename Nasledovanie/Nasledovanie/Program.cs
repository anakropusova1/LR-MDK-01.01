using System;
using System.Collections.Generic;
using System.Text;

namespace Nasledovanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Product> products = Csv.LoadProductsFromFile(@"C:\Scv-файл\Тест2.csv");

            foreach (Product item in products)
            {
                Console.WriteLine($"Товар:{item.GetName()},Кол-во:{item.GetCount()},Скидка{item.CalculateDiscount()}%");
                string name = item.GetName();
                int price = item.GetPrice();
                int count = item.GetCount();
                double discount = item.CalculateDiscount();

                double totalCost = price * count;

                double finalSum = totalCost - (totalCost * discount / 100);

                Console.WriteLine($"Товар:{item.GetName()},Цена:{price},Кол-во:{item.GetCount()},Стоимость:{totalCost},Скидка{item.CalculateDiscount()}%, Сумма со скидкой: {finalSum}");
            }
        }

    }
}
