using System;
using System.Collections;

namespace HashTreeDataStructure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable
            {
                { "001", "Dave Miller" },
                { "002", "Max Antony" },
                { "003", "Christian Eriksen" },
                { "004", "Sergio Roberto" },
                { "005", "Sergio Perez" },
                { "006", "Lewis Nate" },
                { "007", "Blaze Botha" }
            };

            if (hashtable.ContainsValue("Njabulo Dlamini")) {
                Console.WriteLine("This student name is already in the list");
            } else {
                hashtable.Add("008", "Njabulo Dlamini");
            }
            
            if (hashtable.ContainsValue("Christian Eriksen")) {
                Console.WriteLine("This student name is already in the list");
            } else {
                hashtable.Add("009", "Christian Eriksen");
            }
         
            // Get a collection of the keys.
            ICollection keye = hashtable.Keys;
         
            foreach (string key in keye) {
                Console.WriteLine(key + ": " + hashtable[key]);
            }
            Console.ReadKey();
        }
    }
}