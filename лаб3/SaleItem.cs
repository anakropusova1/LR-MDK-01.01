using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб3
{
    public class SaleItem
    {
        private DateTime date_;
        private string product_;
        private int countOfProduct_;
        private double price_;

        public SaleItem(DateTime date, string product, int countOfProduct, double price)
        {
            date_ = date;
            product_ = product;
            countOfProduct_ = countOfProduct;
            price_ = price;
        }
        public string GetProductName() { return product_; }
        public DateTime GetSaleDate() { return date_; }
        public int GetCount() { return countOfProduct_; }
        public double GetPrice() { return price_; }
    }
}
