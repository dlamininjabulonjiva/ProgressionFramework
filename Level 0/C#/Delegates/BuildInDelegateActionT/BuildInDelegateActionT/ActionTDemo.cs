using System;

namespace BuildInDelegateActionT
{
  public class ActionTDemo
  {
    private double _number;

    public ActionTDemo(double number)
    {
      _number = number;
    }

    public double Number
    {
      get => _number;
      set => _number = value;
    }

    public void GetSquare()
    {
      Action<double> square = Square;
      square(_number);
    }

    public void GetCube()
    {
      Action<double> cube = Cube;
      cube(_number);
    }

    private void Square(double number)
    {
      _number = Math.Pow(number, 2);
    }

    public void Cube(double number)
    {
      _number = Math.Pow(number, 3);
    }
  }
}
