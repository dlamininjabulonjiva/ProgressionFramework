using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculatorKata
{
  public class StringCalculator
  {
    private const string CustomSeparatorIndicator = "//";
    private readonly List<string> _separators = new List<string>() { ",", "\n" };
    public int Add(string input)
    {
      if (string.IsNullOrEmpty(input))
      {
        return 0;
      }

      if (input.StartsWith(CustomSeparatorIndicator))
      {
        input = AddCustomSeparators(input);
      }

      var numbers = input.Split(_separators.ToArray(), StringSplitOptions.RemoveEmptyEntries);
      var filteredNumbers = numbers.Select(int.Parse).Where(number => number <= 1000).ToList();
      CheckForNegativeNumbers(filteredNumbers);

      return filteredNumbers.Sum();
    }

    private static void CheckForNegativeNumbers(IEnumerable<int> filteredNumbers)
    {
      var negativeNumbers = filteredNumbers.Where(number => number < 0);

      if (negativeNumbers.Any())
      {
        throw new InvalidOperationException($"Negatives not allowed {string.Join(",", negativeNumbers)}");
      }
    }

    private string AddCustomSeparators(string input)
    {
      string[] customSeparators = {CustomSeparatorIndicator, "[", "]",};
      var customSeparator = input.Split(new string[] {"\n"}, StringSplitOptions.RemoveEmptyEntries).First();

      input = input.Substring(customSeparator.Length, input.Length - customSeparator.Length);
      var allCustomSeparators = customSeparator.Split(customSeparators, StringSplitOptions.RemoveEmptyEntries);

      foreach (var sep in allCustomSeparators)
      {
        _separators.Add(sep);
      }

      return input;
    }
  }
}
