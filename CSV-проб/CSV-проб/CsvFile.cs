using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_проб
{
    internal class CsvFile
    {
        public string Путь_;
        public List<string> строки = new List<string>();

        public CsvFile(string путь)
        {
            Путь_ = путь;
        }

        public void Загрузить()
        {
            строки = new List<string>(File.ReadAllLines(Путь_));
        }

        public void Сохранить()
        {
            File.WriteAllLines(Путь_, строки);
        }
    }
}
