using System.Reflection;

namespace ReflectionExampleCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of MyClass and set its properties.
            var myObject = new MyClass
            {
                MyProperty1 = 42,
                MyProperty2 = "Hello, world!"
            };

            // Use reflection to inspect the properties of the object.
            var objectType = myObject.GetType();
            var properties = objectType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                Console.WriteLine("{0}: {1}", property.Name, property.GetValue(myObject));
            }
        }
    }
}