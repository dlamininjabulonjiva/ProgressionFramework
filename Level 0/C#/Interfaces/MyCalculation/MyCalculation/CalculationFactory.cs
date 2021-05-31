using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalculation
{
  public class CalculationFactory
  {
    public static ICalculator GetCalculator(Operator calculationOperator)
    {
      return calculationOperator switch
      {
        Operator.Add => new CalculateSum(),
        Operator.Divide => new CalculateQuotient(),
        Operator.Subtract => new CalculateDifference(),
        Operator.Multiply => new CalculateProduct(),
        _ => null
      };
    }
  }
}
