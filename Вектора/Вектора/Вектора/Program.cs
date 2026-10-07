using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вектора
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ПРОГРАММА 1: Визуализация векторов ===\n");

            Random rnd = new Random();
            Vector[] vectors = new Vector[5];

            for (int i = 0; i < vectors.Length; i++)
            {
                vectors[i] = VectorHelper.CreateVector(
                    rnd.Next(-5, 6), rnd.Next(-5, 6),
                    rnd.Next(-5, 6), rnd.Next(-5, 6));
            }

            Console.WriteLine("Векторы в виде координат:");
            VectorHelper.PrintVectors(vectors);

            Console.WriteLine("\nВекторы в виде стрелочек:");
            VectorVisualizer.DrawVectorsAsArrows(vectors);

            Console.WriteLine("\n\n=== ПРОГРАММА 2: Поиск одинаковых векторов ===\n");

            // Создаём массив с дубликатами
            Vector[] vectors2 = new Vector[]
            {
            VectorHelper.CreateVector(0, 0, 5, 5),     // 0
            VectorHelper.CreateVector(1, 2, 3, 4),     // 1
            VectorHelper.CreateVector(0, 0, 5, 5),     // 2 — дубликат 0
            VectorHelper.CreateVector(2, 3, 7, 8),     // 3
            VectorHelper.CreateVector(1, 2, 3, 4),     // 4 — дубликат 1
            VectorHelper.CreateVector(10, 10, 20, 20), // 5
            VectorHelper.CreateVector(0, 0, 5, 5),     // 6 — дубликат 0
            VectorHelper.CreateVector(2, 3, 7, 8),     // 7 — дубликат 3
            };

            Console.WriteLine("Все векторы:");
            VectorHelper.PrintVectorsWithIndex(vectors2);

            Console.WriteLine("\nОдинаковые векторы:");
            VectorHelper.FindAndPrintDuplicates(vectors2);
        }
    }
}

