using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб3
{
    public class SaleHistory
    {
        private List<SaleItem> sales_;

        public SaleHistory()
        {
            sales_ = new List<SaleItem>();
        }
        public bool AddSale(SaleItem item)
        {
            int initSize = sales_.Count;
            sales_.Add(item);
            int newSize = sales_.Count;

            return newSize - initSize == 1;
        }
        public List<SaleItem> GetSales()
        {
            return sales_;
        }
    }
}
