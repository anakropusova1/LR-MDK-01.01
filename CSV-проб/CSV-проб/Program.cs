using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_проб
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CsvFile файл = new CsvFile(@"C:\Scv-файл\Тест2.csv");

            файл.Загрузить();

            foreach (string строка in файл.строки)
            {
                Console.WriteLine(строка);
            }
            Console.WriteLine("Загружено строк: " + файл.строки.Count);

            файл.строки.Add("Иван; 28; Москва");

            файл.Сохранить();
            Console.WriteLine("Сохранено!");
        }
    }
}
