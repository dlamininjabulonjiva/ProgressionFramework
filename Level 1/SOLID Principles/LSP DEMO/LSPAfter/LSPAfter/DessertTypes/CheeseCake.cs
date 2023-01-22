using LSPAfter.DessertCategories;

namespace LSPAfter.DessertTypes
{
    public class CheeseCake: FrozenDessert
    {
        public override void CalculateCalories(int grams)
        {
            Console.WriteLine("Total calories " + grams * 20);
        }

        public override void GetRoomTemperatureMeltingPoint()
        {
            Console.WriteLine("Melting room temperature is 30 degrees celcius");
        }
    }
}
