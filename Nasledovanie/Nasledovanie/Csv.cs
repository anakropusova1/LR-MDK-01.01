using Nasledovanie;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nasledovanie
{
    public class Csv
    {
        public static List<Product> LoadProductsFromFile(string filePath)
        {
            List<Product> products = new List<Product>();

            if (!File.Exists(filePath))
            {
                return products;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(';');

                if (parts.Length < 4) continue;

                string name = parts[0].Trim();
                string countStr = parts[1].Trim();
                string priceStr = parts[2].Trim();
                string type = parts[3].Trim().ToLower();

                if (!int.TryParse(countStr, out int count) || !int.TryParse(priceStr, out int price))
                {
                    continue;
                }

                Product product;

                if (type == "drinks" || type == "drunks" || type == "напитки")
                {
                    product = new Drinks(); 
                }
                else if (type == "cars" || type == "машины" || type == "авто")
                {
                    product = new Cars();
                }
                else
                {
                    product = new Product();
                }

                product.SetName(name);
                product.SetPrice(price);
                product.SetCount(count);

                products.Add(product);
            }

            return products;
        }
    }
}
