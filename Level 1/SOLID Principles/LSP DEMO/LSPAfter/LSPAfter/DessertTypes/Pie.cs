using System;

namespace LSPAfter.DessertTypes
{
    public class Pie: IHotDessert
    {
        public void CalculateCalories(int grams)
        {
            Console.WriteLine("Total calories " + grams * 25);
        }
    }
}
