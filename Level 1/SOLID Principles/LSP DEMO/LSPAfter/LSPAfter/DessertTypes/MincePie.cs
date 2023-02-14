using System;

namespace LSPAfter.DessertTypes
{
    public class MincePie: IDessert
    {
        public void CalculateCalories(int grams)
        {
            Console.WriteLine("Total calories " + grams * 25);
        }
    }
}
