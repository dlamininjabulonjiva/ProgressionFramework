using System;
using System.Collections.Generic;
using System.Text;

namespace Travel
{
  public class TravelFactory
  {
    public decimal CalculateDrive(int kilometer, ITravel travel)
    {
      return travel.Drive(kilometer);
    }
  }
}
