﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalculation
{
  public class CalculateProduct : ICalculator
  {
    public int CalculationFor(int num1, int num2)
    {
      return num1 * num2;
    }
  }
}
