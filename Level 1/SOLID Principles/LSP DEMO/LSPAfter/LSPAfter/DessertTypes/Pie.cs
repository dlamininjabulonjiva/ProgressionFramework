using LSPAfter.DessertCategories;

namespace LSPAfter.DessertTypes
{
    public class Pie: HotDessert
    {
        public override void CalculateCalories(int grams)
        {
            Console.WriteLine("Total calories " + grams * 25);
        }
    }
}
