using System;
using System.Collections;

namespace ArrayListExampleProject
{
  public class ArrayListExample
  {
    public static void Main(string[] args)
    {
      NonGenericCollectionArrayList();
      Console.ReadKey();
    }

    public static void NonGenericCollectionArrayList()
    {
      var values = new ArrayList
      {
        "David", 56, "Nate", 36, "Steve", 25
      };

      foreach (var value in values)
      {
        Console.WriteLine(value);
      }
    }
  }
}
