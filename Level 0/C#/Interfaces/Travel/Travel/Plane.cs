using System;
using System.Collections.Generic;
using System.Text;

namespace Travel
{
  public class Plane : ITravel
  {
    private int _kilometerCost;

    public Plane(int kilometerCost)
    {
      _kilometerCost = kilometerCost;
    }

    public decimal Drive(int kilometers)
    {
      if (kilometers > 1000)
      {
        _kilometerCost -= 10;
      }

      return kilometers * _kilometerCost;
    }
  }
}
