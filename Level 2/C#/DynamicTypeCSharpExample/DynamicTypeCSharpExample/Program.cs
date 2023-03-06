using System;

namespace DynamicTypeCSharpExample
{
    public class Program
    {
        public static void Main()
        {
            dynamic value1 = 10;
            dynamic value2 = "hello";

            Console.WriteLine("Value 1 is of type: " + value1.GetType());
            Console.WriteLine("Value 2 is of type: " + value2.GetType());
            Console.WriteLine("");

            value1 = "world";

            Console.WriteLine("Value 1 is now of type: " + value1.GetType());

            value2 = 3.14;

            Console.WriteLine("Value 2 is now of type: " + value2.GetType());
        }
    }
}