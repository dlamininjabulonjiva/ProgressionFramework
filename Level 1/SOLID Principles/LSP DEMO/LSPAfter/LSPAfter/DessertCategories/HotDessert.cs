namespace LSPAfter.DessertCategories
{
    public class HotDessert: Dessert
    {
        public override void CalculateCalories(int grams)
        {
            Console.WriteLine("Total calories " + grams * 10);
        }
    }
}
