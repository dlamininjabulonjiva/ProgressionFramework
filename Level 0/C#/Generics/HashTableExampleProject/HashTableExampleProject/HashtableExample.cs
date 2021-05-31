using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace HashTableExampleProject
{
  public class HashtableExample
  {
    public static void Main(string[] args)
    {
      NonGenericCollectionHashtable();
      Console.ReadKey();
    }

    public static void NonGenericCollectionHashtable()
    {
      var table = new Hashtable
      {
        {"Email", "test@chillisoft.co.za"}, 
        {"Username", "test"}, 
        {"Password", "12345"}
      };

      foreach (var key in table.Keys)
      {
        Console.WriteLine("The value for " + key + " is: " + table[key]);
      }
    }
  }
}
