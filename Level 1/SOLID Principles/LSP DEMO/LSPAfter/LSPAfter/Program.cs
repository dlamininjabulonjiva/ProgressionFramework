using LSPAfter.DessertCategories;
using LSPAfter.DessertTypes;

namespace LSPAfter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //super class
            PrintDessert();

            //According to LSP, objects of a superclass must be replaceable or interchangeable with objects of its subclasses without breaking the code.
            PrintIceCreamDessert();
            PrintCheeseCakeDessert();

            //GetRoomTemperatureMeltingPoint method doesn't break anymore because the Pie subclass is now a Hot Dessert
            //And Hot Desserts don't have melting points.
            PrintPieDessert();
        }

        public static void PrintDessert()
        {
            Console.WriteLine("Superclass -> Frozen Dessert's output.....");
            var dessertType1 = new FrozenDessert();
            dessertType1.CalculateCalories(2);
            dessertType1.GetRoomTemperatureMeltingPoint();

            Console.WriteLine("Superclass -> Hot Dessert's output.....");
            var dessertType2 = new HotDessert();
            dessertType2.CalculateCalories(2);

            Console.WriteLine("");
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