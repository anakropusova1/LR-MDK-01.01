using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class chet
    {
        public static int CalculateStrips(double length, double width, double rollWidth)
        {
            double perimeter = 2 * (length + width);
            return (int)Math.Ceiling(perimeter / rollWidth);
        }
    }
}
