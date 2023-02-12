using LSPAfter.DessertTypes;

namespace LSPAfter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //According to LSP, objects of a superclass must be replaceable or interchangeable with objects of its subclasses without breaking the code.
            PrintIceCreamDessert();
            PrintCheeseCakeDessert();
            PrintPieDessert();
        }

        public static void PrintIceCreamDessert()
        {
            Console.WriteLine("Subclass -> Ice Cream Dessert's output.....");
            var dessert = new IceCream();
            dessert.CalculateCalories(2);
            dessert.GetRoomTemperatureMeltingPoint();

            Console.WriteLine("");
        }

        public static void PrintCheeseCakeDessert()
        {
            Console.WriteLine("Subclass -> Cheese Cake Dessert's output.....");
            var dessert = new CheeseCake();
            dessert.CalculateCalories(2);
            dessert.GetRoomTemperatureMeltingPoint();

            Console.WriteLine("");
        }

        public static void PrintPieDessert()
        {
            Console.WriteLine("Subclass -> Pie Dessert's output.....");
            var dessert = new Pie();
            dessert.CalculateCalories(2);

            Console.WriteLine("");
        }
    }
}