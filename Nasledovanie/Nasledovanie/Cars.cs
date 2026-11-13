using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie
{
    public class Cars : Product
    {
        public override double CalculateDiscount()
        {
            if (count_ >= 5 && count_ <= 10)
            {
                return 15;
            }

            else if (count_ > 10)
            {
                return 25;
            }

            return base.CalculateDiscount();
        }
    }
}
