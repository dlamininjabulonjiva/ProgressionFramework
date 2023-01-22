using LSPAfter.DessertCategories;

namespace LSPAfter.DessertTypes
{
    public class IceCream: FrozenDessert
    {
        public override void CalculateCalories(int grams)
        {
            Console.WriteLine("Total calories " + grams * 15);
        }

        public override void GetRoomTemperatureMeltingPoint()
        {
            Console.WriteLine("Melting room temperature is 10 degrees celcius");
        }
    }
}
