namespace CarApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICar basicCar = new BasicCar();
            Console.WriteLine("Basic Car's Description is: " + basicCar.GetDescription());
            Console.WriteLine("Basic Car's Cost is: " + basicCar.GetCost());
            Console.WriteLine("");

            ICar luxuryCar = new LuxuryCar(basicCar);
            Console.WriteLine("Luxury Car's Description is: " + luxuryCar.GetDescription());
            Console.WriteLine("Luxury Car's Cost is: " + luxuryCar.GetCost());
            Console.WriteLine("");

            ICar sportsCar = new SportsCar(luxuryCar);
            Console.WriteLine("Sports Car's Description is: " + sportsCar.GetDescription());
            Console.WriteLine("Sports Car's Cost is: " + sportsCar.GetCost());
        }
    }
}