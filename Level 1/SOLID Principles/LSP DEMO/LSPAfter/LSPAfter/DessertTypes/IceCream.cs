using System;

namespace LSPAfter.DessertTypes
{
    public class IceCream: IFrozenDessert
    {
        public void CalculateCalories(int grams)
        {
            Console.WriteLine("Total calories " + grams * 15);
        }

        public void GetRoomTemperatureMeltingPoint()
        {
            Console.WriteLine("Melting room temperature is 10 degrees celcius");
        }
    }
}
