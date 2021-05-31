using System;

namespace MyMath
{
  public class MyCalculation
  {
    private int _total;

    public MyCalculation(int total)
    {
      _total = total;
    }

    public int Total
    {
      get => _total;
      set => _total = value;
    }

    public void AddSumToTotal(int input1, int input2)
    {
      _total += input1 + input2;
    }

    public void AddDifferenceToTotal(int input1, int input2)
    {
      _total += input1 - input2;
    }

    public void AddMultiplicationToTotal(int input1, int input2)
    {
      _total += input1 * input2;
    }

    public void AddDivisionToTotal(int input1, int input2)
    {
      _total += input1 / input2;
    }
  }
}