using LSPBefore.DessertTypes;

namespace LSPBefore
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

            //GetRoomTemperatureMeltingPoint method breaks on the Pie subclass which violets the Liskov Substitution Principle 
            PrintMincePieDessert();
        }

        public static void PrintDessert()
        {
            Console.WriteLine("Superclass -> Dessert's output.....");
            var dessert = new Dessert();
            dessert.CalculateCalories(2);
            dessert.GetRoomTemperatureMeltingPoint();

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

        public static void PrintMincePieDessert()
        {
            Console.WriteLine("Subclass -> Mince Pie Dessert's output.....");
            var dessert = new MincePie();
            dessert.CalculateCalories(2);
            dessert.GetRoomTemperatureMeltingPoint();

            Console.WriteLine("");
        }
    }
}