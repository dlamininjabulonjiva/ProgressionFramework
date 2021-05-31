using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstDelegate
{
  public class CalculationDelegate
  {
    public delegate int MyTotal(int number);

    private int _total;

    public CalculationDelegate(int total)
    {
      _total = total;
    }

    public int AddNumberToTotal(int number)
    {
      MyTotal total = AddNumber;
      total(number);
      return GetTotal();
    }

    public int MultiplyNumberWithTotal(int number)
    {
      MyTotal total = MultiplyNumber;
      total(number);
      return GetTotal();
    }

    public int SubtractNumberFromTotal(int number)
    {
      MyTotal total = SubtractNumber;
      total(number);
      return GetTotal();
    }

    public int AddNumber(int number)
    {
      _total += number;
      return _total;
    }

    public int MultiplyNumber(int number)
    {
      _total *= number;
      return _total;
    }

    public int SubtractNumber(int number)
    {
      _total -= number;
      return _total;
    }

    public int GetTotal()
    {
      return _total;
    }
  }
}
