using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаб3
{
    class Program
    {
        private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Nomenclature nomenclature = new Nomenclature();
        nomenclature.AddProduct(ProductGroup.Gruz, "Картошка");
        nomenclature.AddProduct(ProductGroup.Gruz, "Морковь");
        nomenclature.AddProduct(ProductGroup.NotGruz, "Мыло");
        nomenclature.AddProduct(ProductGroup.NotGruz, "Шампунь");

        SaleHistory history = new SaleHistory();

        history.AddSale(new SaleItem(new DateTime(2023, 10, 1), "Картошка", 5, 30.0));
        history.AddSale(new SaleItem(new DateTime(2023, 10, 5), "Морковь", 3, 25.0));
        history.AddSale(new SaleItem(new DateTime(2023, 10, 10), "Картошка", 2, 30.0)); // Повторная продажа
        history.AddSale(new SaleItem(new DateTime(2023, 10, 15), "Мыло", 4, 50.0));
        history.AddSale(new SaleItem(new DateTime(2023, 11, 1), "Шампунь", 1, 200.0)); // Ноябрь - вне периода

        DateTime start = new DateTime(2023, 10, 1);
        DateTime end = new DateTime(2023, 10, 31);

        ProfitByPeriodReport report = Accountant.MakeReport(history, start, end);

        Console.WriteLine("=== ОТЧЁТ ЗА ОКТЯБРЬ 2023 ===");
        Console.WriteLine();

        foreach (ReportRow row in report.GetReportRows())
        {
            Console.WriteLine($"Товар: {row.product_,-10} | Количество: {row.count_,2} | Сумма: {row.cost_,6} руб.");
        }

        Console.WriteLine();
        Console.WriteLine("=== ПРОВЕРКА НОМЕНКЛАТУРЫ ===");
        Console.WriteLine();

        string testProduct = "Морковь";
        ProductGroup? group = nomenclature.GetProductGroupByProduct(testProduct);

        if (group.HasValue)
        {
            Console.WriteLine($"Товар '{testProduct}' относится к группе: {group.Value}");
        }
        else
        {
            Console.WriteLine($"Товар '{testProduct}' не найден в номенклатуре");
        }

        Console.WriteLine();
    }
}