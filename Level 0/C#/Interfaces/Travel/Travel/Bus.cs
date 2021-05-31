using System;
using System.Collections.Generic;
using System.Text;

namespace Travel
{
  public class Bus : ITravel
  {
    private int _kilometerCost;

    public Bus(int kilometerCost)
    {
      _kilometerCost = kilometerCost;
    }

    public decimal Drive(int kilometers)
    {
      if (kilometers > 1000)
      {
        _kilometerCost -= 3;
      }

      return kilometers * _kilometerCost;
    }
  }
}
