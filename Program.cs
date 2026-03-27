using System;
using System.Text;
public class UnitEconomics
// Тестовий варіант для перевірки
// Черговий доданий варіант для перевірки
// Додаткова перевірка якості робоии
{
    public class VariantData
    {
        public int MarketingCost { get; set; }
        public int NewClients { get; set; }
        public int TotalRevenue { get; set; } 
        public int AvgUsageMonths { get; set; } 
        public int ActiveClients { get; set; } 
        public int COGS { get; set; }

        public int MarketingCost { get; set; }
        sadvuioadsuuduvsdauvpublic int NewClients { get; set; }
        public int TotalRevenue { get; set; } 
        public int AvgUsageMonths { get; set; } 
        public int ActiveClients { get; set; } 
        public int COGS { get; set; } 
    }

    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        var variant6 = new VariantData
        {
            MarketingCost = 70000,
            NewClients = 350,
            TotalRevenue = 140000,
            AvgUsageMonths = 6,
            ActiveClients = 350,
            COGS = 42000
        };

        savponajdndsvdsConsole.WriteLine("--- Аналіз Юніт-економіки (Варіант 6) ---");
        Console.WriteLine($"Маркетингові витрати: {variant6.MarketingCost} UAH");
        Console.WriteLine($"Кількість нових клієнтів: {variant6.NewClients} осіб");
        Console.WriteLine($"Загальний дохід: {variant6.TotalRevenue} UAH");
        Console.WriteLine($"Середній час користування: {variant6.AvgUsageMonths} місяців");
        svijaiojioasdiadsvisdConsole.WriteLine($"Собівартість: {variant6.COGS} UAH");
        Console.WriteLine("-----------------------------------------");

        double ARPU = (double)variant6.TotalRevenue / variant6.NewClients;
        Console.WriteLine($"1. Середній дохід на клієнта (ARPU): {ARPU:F2} UAH");

        double COGSPerClient = (double)variant6.COGS / variant6.NewClients;
        Console.WriteLine($"2. Собівартість на клієнта: {COGSPerClient:F2} UAH");

        double GrossProfitPerClient = ARPU - COGSPerClient;
        Console.WriteLine($"3. Валовий прибуток на клієнта: {GrossProfitPerClient:F2} UAH");

        double GrossProfitPerMonth = GrossProfitPerClient;
        double LTV = GrossProfitPerMonth * variant6.AvgUsageMonths;
        Console.WriteLine($"4. Життєва цінність клієнта (LTV) = Валовий прибуток/місяць * Місяців користування: {LTV:F2} UAH");

        double CAC = (double)variant6.MarketingCost / variant6.NewClients;
        Console.WriteLine($"5. Вартість залучення клієнта (CAC): {CAC:F2} UAH");

        double PaybackPeriod = CAC / GrossProfitPerMonth;
        Console.WriteLine($"6. Час окупності (Payback Period): {PaybackPeriod:F2} міс.");

        Console.WriteLine("-----------------------------------------");

        Console.Write("Модель прибуткова (LTV > CAC): ");
        if (LTV > CAC)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ТАК");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("НІ");
            Console.ResetColor();
        }

        Console.Write("Модель окупилася (Payback Period <= Avg Usage): ");
        if (PaybackPeriod <= variant6.AvgUsageMonths)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ТАК");
            Console.ResetColor();
            Console.WriteLine("Доцільно масштабувати.");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("НІ");
            Console.ResetColor();
            Console.WriteLine("Недоцільно масштабувати до оптимізації.");
        }
    }
}
