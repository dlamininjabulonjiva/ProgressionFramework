using System.Collections.Generic;

namespace CalculateAveragePattern
{
  public class CalculateAverageFactory
  {
    public double CalculatorAverageFor(List<double> values, ICalculateAverage calculateAverage)
    {
      return calculateAverage.AverageFor(values);
    }
  }
}
