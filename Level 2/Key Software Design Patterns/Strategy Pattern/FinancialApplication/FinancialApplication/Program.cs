using FinancialApplication.Pricing_Strategies;

namespace FinancialApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            FinancialInstrument financialInstrument = new FinancialInstrument(100, new FlatMarkupPricingStrategy(10));
            decimal price1 = financialInstrument.CalculatePrice();
            Console.WriteLine($"Flat Mark Up Price is: {price1}");

            financialInstrument.SetPricingStrategy(new PerPersonMarkupPricingStrategy(5, 2));
            decimal price2 = financialInstrument.CalculatePrice();
            Console.WriteLine($"Per Person Markup Price is: {price2}");

            financialInstrument.SetPricingStrategy(new PriceByCategoryPricingStrategy(10, "food"));
            decimal price3 = financialInstrument.CalculatePrice();
            Console.WriteLine($"Price By Category is: {price3}");
        }
    }
}