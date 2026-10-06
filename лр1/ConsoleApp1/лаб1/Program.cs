using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            double length = input.ReadPositiveDouble("Введите длину комнаты (м): ");
            double width = input.ReadPositiveDouble("Введите ширину комнаты (м): ");
            double height = input.ReadPositiveDouble("Введите высоту комнаты (м): ");
            double rollWidth = input.ReadPositiveDouble("Введите ширину рулона (м): ");
            double rollLength = input.ReadPositiveDouble("Введите длину рулона (м): ");

            int totalStrips = chet.CalculateStrips(length, width, rollWidth);
            int stripsPerRoll = chet.CalculateStripsPerRoll(rollLength, height);
            int rolls = chet.CalculateRolls(totalStrips, stripsPerRoll);

            Console.WriteLine("Количество полос: " + totalStrips);
            Console.WriteLine("Количество рулонов: " + rolls);
        }
    }
}
