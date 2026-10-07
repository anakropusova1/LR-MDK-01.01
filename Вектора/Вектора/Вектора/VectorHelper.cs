using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вектора
{
    internal static class VectorHelper
    {
        public static Vector CreateVector(int x0, int y0, int x1, int y1)
        {
            Vector result = new Vector();
            result.start_.x_ = x0;
            result.start_.y_ = y0;
            result.end_.x_ = x1;
            result.end_.y_ = y1;
            return result;
        }

        // Создание вектора из двух точек
        public static Vector CreateVector(Point start, Point end)
        {
            Vector result = new Vector();
            result.start_ = start;
            result.end_ = end;
            return result;
        }

        // Вывод одного вектора
        public static void Print(Vector v)
        {
            Console.WriteLine($"Vector([{v.start_.x_},{v.start_.y_}] -> [{v.end_.x_},{v.end_.y_}])");
        }

        // Вывод массива векторов
        public static void PrintVectors(Vector[] vectors)
        {
            foreach (Vector v in vectors)
            {
                Print(v);
            }
        }

        // Вывод массива с номерами
        public static void PrintVectorsWithIndex(Vector[] vectors)
        {
            for (int i = 0; i < vectors.Length; i++)
            {
                Console.Write($"  Вектор #{i}: ");
                PrintInline(vectors[i]);
                Console.WriteLine();
            }
        }

        // Вывод вектора в одну строку (без переноса)
        public static void PrintInline(Vector v)
        {
            Console.Write($"[{v.start_.x_},{v.start_.y_}] -> [{v.end_.x_},{v.end_.y_}]");
        }

        // Проверка на равенство двух векторов
        public static bool IsEqual(Vector a, Vector b)
        {
            return a.start_.x_ == b.start_.x_ &&
                   a.start_.y_ == b.start_.y_ &&
                   a.end_.x_ == b.end_.x_ &&
                   a.end_.y_ == b.end_.y_;
        }

        // Поиск и вывод одинаковых векторов
        public static void FindAndPrintDuplicates(Vector[] vectors)
        {
            bool[] printed = new bool[vectors.Length];

            for (int i = 0; i < vectors.Length; i++)
            {
                if (printed[i]) continue;

                List<int> sameIndices = new List<int>();
                sameIndices.Add(i);

                for (int j = i + 1; j < vectors.Length; j++)
                {
                    if (IsEqual(vectors[i], vectors[j]))
                    {
                        sameIndices.Add(j);
                        printed[j] = true;
                    }
                }

                if (sameIndices.Count > 1)
                {
                    Console.Write($"  Одинаковые векторы (номера: ");
                    for (int k = 0; k < sameIndices.Count; k++)
                    {
                        Console.Write(sameIndices[k]);
                        if (k < sameIndices.Count - 1) Console.Write(", ");
                    }
                    Console.Write($"): ");
                    PrintInline(vectors[i]);
                    Console.WriteLine();
                }
            }
        }
    }
}
