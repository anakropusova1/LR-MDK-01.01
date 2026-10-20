using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб3
{
    public class Accountant
    {
        public static ProfitByPeriodReport MakeReport(SaleHistory history, DateTime startPeriod, DateTime endPeriod)
        {
            Dictionary<string, ReportRow> totalRows = new Dictionary<string, ReportRow>();
            List<SaleItem> items = history.GetSales();

            foreach (SaleItem item in items)
            {
                string saleProduct = item.GetProductName();
                DateTime saleDate = item.GetSaleDate();
                if (saleDate < startPeriod || saleDate > endPeriod)
                {
                    continue;
                }

                if (totalRows.ContainsKey(saleProduct))
                {
                    // Теперь это работает корректно, так как ReportRow - это class (ссылочный тип)
                    ReportRow row = totalRows[saleProduct];
                    row.count_ += item.GetCount();
                    row.cost_ += item.GetCount() * item.GetPrice();
                }
                else
                {
                    totalRows.Add(saleProduct, new ReportRow
                    {
                        product_ = saleProduct,
                        count_ = item.GetCount(),
                        cost_ = item.GetCount() * item.GetPrice()
                    });
                }
            }
        }
    }
}
