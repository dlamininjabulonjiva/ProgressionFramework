using System;
using System.Collections.Generic;

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

      return numbers.Length > 1 ? GetSum(numbers) : ConvertStringToInt(input);
    }

    private static int GetSum(IEnumerable<string> numbers)
    {
      var sum = 0;

      foreach (var number in numbers)
      {
        if (ConvertStringToInt(number) > 1000)
        {
          continue;
        }

        sum += ConvertStringToInt(number);
      }

      return sum;
    }

    private static int ConvertStringToInt(string input)
    {
      var num = int.Parse(input);

      if (num < 0)
      {
        throw new InvalidOperationException("Negatives not allowed");
      }

      return num;
    }
  }
}