namespace LSPBefore
{
    public class Dessert
    {
        public virtual void CalculateCalories(int grams)
        {
            Console.WriteLine("Total calories " + grams * 10);
        }

        public virtual void GetRoomTemperatureMeltingPoint()
        {
            Console.WriteLine("Melting room temperature is 20 degrees celcius");
        }
    }
}
