using System;
using System.Collections.Generic;

namespace RomanNumeralsKata
{
  public class RomanNumerals
  {
    public string ConvertNumberToRomanNumeral(int input)
    {
      var romanString = "";
      var dictionary = new Dictionary<int, string>
      {
          { 1000, "M" },
          { 900, "CM" },
          { 500, "D" },
          { 400, "CD" },
          { 100, "C" },
          { 90, "XC" },
          { 50, "L" },
          { 40, "XL" },
          { 10, "X" },
          { 9, "IX" },
          { 5, "V" },
          { 4, "IV" },
          { 1, "I" },
      };

      if (input < 0)
      {
        throw new InvalidOperationException("Please use a positive integer greater than zero.");
      }

      foreach (var item in dictionary)
      {
        while (input >= item.Key)
        {
          romanString += item.Value;
          input -= item.Key;
        }
      }

      return romanString;
    }

    public string ConvertToRomanNumeral(int input)
    {
      if (input < 0)
      {
        throw new InvalidOperationException("Please use a positive integer greater than zero.");
      }

      var romanString = "";
      var remain = input;
      while (remain > 0)
      {
        if (remain >= 1000) 
        { 
          romanString += "M";
          remain -= 1000;
        }
        else if (remain >= 900)
        {
          romanString += "CM";
          remain -= 900;
        }
        else if (remain >= 500)
        {
          romanString += "D";
          remain -= 500;
        }
        else if (remain >= 400)
        {
          romanString += "CD";
          remain -= 400;
        }
        else if (remain >= 100) 
        { 
          romanString += "C"; 
          remain -= 100;
        }
        else if (remain >= 90)
        {
          romanString += "XC";
          remain -= 90;
        }
        else if (remain >= 50) 
        {
          romanString += "L";
          remain -= 50;
        }
        else if (remain >= 40)
        {
          romanString += "XL";
          remain -= 40;
        }
        else if (remain >= 10)
        {
          romanString += "X";
          remain -= 10;
        }
        else if (remain >= 9)
        {
          romanString += "IX";
          remain -= 9;
        }
        else if (remain >= 5)
        {
          romanString += "V";
          remain -= 5;
        }
        else if (remain >= 4)
        {
          romanString += "IV";
          remain -= 4;
        }
        else
        {
          romanString += "I";
          remain -= 1;
        }
      }

      return romanString;
    }
  }
}