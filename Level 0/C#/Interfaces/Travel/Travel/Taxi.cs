using System;
using System.Collections.Generic;
using System.Text;

namespace Travel
{
  public class Taxi : ITravel
  {
    private readonly int _kilometerCost;

    public Taxi(int kilometerCost)
    {
      _kilometerCost = kilometerCost;
    }

    public decimal Drive(int kilometers)
    {
      return kilometers * _kilometerCost;
    }
  }
}
