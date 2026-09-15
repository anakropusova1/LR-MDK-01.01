using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = ReadPositiveDouble("Введите длину комнаты (м): ");
            double width = ReadPositiveDouble("Введите ширину комнаты (м): ");
            double height = ReadPositiveDouble("Введите высоту комнаты (м): ");
            double rollWidth = ReadPositiveDouble("Введите ширину рулона (м): ");
            double rollLength = ReadPositiveDouble("Введите длину рулона (м): ");

            int totalStrips = CalculateStrips(length, width, rollWidth);
            int stripsPerRoll = CalculateStripsPerRoll(rollLength, height);
            int rolls = CalculateRolls(totalStrips, stripsPerRoll);

            Console.WriteLine("Количество полос: " + totalStrips);
            Console.WriteLine("Количество рулонов: " + rolls);
        }
    }
}
