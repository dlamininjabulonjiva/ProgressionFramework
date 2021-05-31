using System.Collections.Generic;
using System.Linq;

namespace CalculateAveragePattern
{
  public class CalculateAverageByMedian : ICalculateAverage
  {
    public double AverageFor(List<double> values)
    {
      double averageByMedian;
      var sortedValues = values.OrderBy(v => v).ToList();

      if (sortedValues.Count % 2 == 1)
      {
        averageByMedian = sortedValues[(sortedValues.Count - 1) / 2];
        return averageByMedian;
      }

      averageByMedian = (sortedValues[(sortedValues.Count / 2) - 1] + sortedValues[sortedValues.Count / 2]) / 2;
      return averageByMedian;
    }
  }
}
