using System;
// ReSharper disable ConvertToLambdaExpression
// ReSharper disable ConvertToLocalFunction

namespace BuildInDelegateFuncT
{
  public class FuncTDemo
  {
    private readonly double _number;
    public FuncTDemo(double number)
    {
      _number = number;
    }

    public double GetSquare()
    {
      Func<double, double> square = delegate(double number) { return number * number; };
      return square(_number);
    }

    public double GetCube()
    {
      Func<double, double> cube = number => number * number * number ;
      return cube(_number);
    }
  }
}