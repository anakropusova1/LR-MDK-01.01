using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вектора
{
    public static class VectorVisualizer
    {
        static char[] arrowChars = { '→', '↗', '↑', '↖', '←', '↙', '↓', '↘' };

        public static void DrawVectorsAsArrows(Vector[] vectors)
        {
            int width = 21;   // ширина сетки
            int height = 11;  // высота сетки
            int originX = 10; // центр по X
            int originY = 5;  // центр по Y

            char[,] grid = new char[height, width];

            // Заполняем сетку пробелами
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    grid[y, x] = ' ';

            // Рисуем оси
            for (int x = 0; x < width; x++) grid[originY, x] = '-';
            for (int y = 0; y < height; y++) grid[y, originX] = '|';
            grid[originY, originX] = '+';

            // Рисуем каждый вектор
            for (int i = 0; i < vectors.Length; i++)
            {
                Vector v = vectors[i];

                int sx = v.start_.x_ + originX;
                int sy = originY - v.start_.y_;
                int ex = v.end_.x_ + originX;
                int ey = originY - v.end_.y_;

                // Ограничиваем в пределах сетки
                sx = Math.Max(0, Math.Min(width - 1, sx));
                sy = Math.Max(0, Math.Min(height - 1, sy));
                ex = Math.Max(0, Math.Min(width - 1, ex));
                ey = Math.Max(0, Math.Min(height - 1, ey));

                // Алгоритм Брезенхэма для рисования линии
                int dx = Math.Abs(ex - sx);
                int dy = Math.Abs(ey - sy);
                int sxStep = sx < ex ? 1 : -1;
                int syStep = sy < ey ? 1 : -1;
                int err = dx - dy;

                int cx = sx, cy = sy;

                while (true)
                {
                    if (cx == ex && cy == ey)
                    {
                        int dirIndex = GetArrowDirection(ex - sx, ey - sy);
                        grid[cy, cx] = arrowChars[dirIndex];
                        break;
                    }

                    if (grid[cy, cx] == ' ')
                        grid[cy, cx] = '*';

                    int e2 = 2 * err;
                    if (e2 > -dy) { err -= dy; cx += sxStep; }
                    if (e2 < dx) { err += dx; cy += syStep; }
                }
            }

            // Выводим сетку
            Console.WriteLine();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(grid[y, x]);
                }
                Console.WriteLine();
            }

            // Легенда
            Console.WriteLine("\nЛегенда:");
            Console.WriteLine("  +  — начало координат");
            Console.WriteLine("  -  — ось X");
            Console.WriteLine("  |  — ось Y");
            Console.WriteLine("  *  — линия вектора");
            Console.WriteLine("  →↗↑↖←↓↘ — конец вектора (стрелка)");
        }

        static int GetArrowDirection(int dx, int dy)
        {
            if (dx > 0 && dy == 0) return 0;  // →
            if (dx > 0 && dy < 0) return 1;  // ↗
            if (dx == 0 && dy < 0) return 2; // ↑
            if (dx < 0 && dy < 0) return 3;  // ↖
            if (dx < 0 && dy == 0) return 4; // ←
            if (dx < 0 && dy > 0) return 5;  // 
            if (dx == 0 && dy > 0) return 6; // ↓
            if (dx > 0 && dy > 0) return 7;  // ↘
            return 0;
        }
    }
}
