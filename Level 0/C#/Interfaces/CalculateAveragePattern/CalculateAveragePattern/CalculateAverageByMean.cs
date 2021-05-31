using System.Collections.Generic;
using System.Linq;

namespace CalculateAveragePattern
{
  public class CalculateAverageByMean : ICalculateAverage
  {
    public double AverageFor(List<double> values)
    {
      var averageByMean = values.Sum() / values.Count;
      return averageByMean;
    }
  }
}
