using System.Collections.Generic;

namespace Nasledovanie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Product baseProd = new Product();
            baseProd.SetName("Обычный товар (без скидки)");
            baseProd.SetPrice(100);
            baseProd.SetCount(15);
            products.Add(baseProd);


            Drinks drink1 = new Drinks();
            drink1.SetName("Минеральная вода");
            drink1.SetPrice(50);
            drink1.SetCount(30);
            products.Add(drink1);

            Drinks drink2 = new Drinks();
            drink2.SetName("Сок Апельсиновый");
            drink2.SetPrice(120);
            drink2.SetCount(200); 
            products.Add(drink2);

            Drinks drink3 = new Drinks();
            drink3.SetName("Холодный чай");
            drink3.SetPrice(90);
            drink3.SetCount(400); 
            products.Add(drink3);


            Cars car1 = new Cars();
            car1.SetName("Легковой Седан");
            car1.SetPrice(900000);
            car1.SetCount(7); 
            products.Add(car1);

            Cars car2 = new Cars();
            car2.SetName("Внедорожник 4x4");
            car2.SetPrice(2500000);
            car2.SetCount(15); 
            products.Add(car2);
        }
    }
}
