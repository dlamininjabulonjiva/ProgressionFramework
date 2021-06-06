using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculatorKata
{
  public class StringCalculator
  {
    public int Add(string input)
    {
      var numbers = input.Split(new char[] {',', '\n', '%' });

      if (string.IsNullOrEmpty(input))
      {
        return 0;
      }

      var filteredNumbers = numbers.Select(int.Parse).Where(number => number < 1000).ToList();
      var negativeNumbers = filteredNumbers.Where(number => number < 0);

      if (negativeNumbers.Any())
      {
        throw new InvalidOperationException("Negatives not allowed");
      }

      return filteredNumbers.Count() > 1 ? filteredNumbers.Sum() : int.Parse(input);
    }
  }
}