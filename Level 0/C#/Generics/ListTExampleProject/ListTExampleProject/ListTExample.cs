using System;
using System.Collections.Generic;

namespace ListTExampleProject
{
  public class ListTExample
  {
    public static void Main(string[] args)
    {
      GenericCollectionListT();
      Console.ReadKey();
    }

    public static void GenericCollectionListT()
    {
      var numbers = new List<int>
      {
        10,
        20,
        30,
        40,
        50
      };

      foreach (var number in numbers)
      {
        Console.WriteLine(number);
      }
    }
  }
}
