using System;

namespace LSPAfter.DessertTypes
{
    public class CheeseCake: IFrozenDessert
    {
        public void CalculateCalories(int grams)
        {
            Console.WriteLine("Total calories " + grams * 20);
        }

        public void GetRoomTemperatureMeltingPoint()
        {
            Console.WriteLine("Melting room temperature is 30 degrees celcius");
        }
    }
}
