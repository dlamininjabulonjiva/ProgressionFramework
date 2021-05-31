using System;
using System.Collections.Generic;

namespace DictionaryExampleProject
{
  public class DictionaryExample
  {
    public static void Main(string[] args)
    {
      GenericCollectionDictionary();
      Console.ReadKey();
    }

    public static void GenericCollectionDictionary()
    {
      var user1 = new string[]{"John", "35", "john@chillisoft.co.za", "0789563256"};
      var user2 = new string[]{"Cindy", "28", "cindy@chillisoft.co.za", "0736215896"};
      var user3 = new string[]{"Angel", "25", "angel@chillisoft.co.za", "0819036512"};

      var dictionary = new Dictionary<int, string[]>
      {
        {1, user1}, 
        {2, user2}, 
        {3, user3}
      };

      foreach (var dict in dictionary)
      {
        var users = dict.Value;

        foreach (var user in users)
        {
          Console.WriteLine(user);
        }
      }
    }
  }
}
