using System;

namespace AgeCalculatorKata
{
  public class AgeCalculator
  {
    public int Calculate(DateTime dateOfBirth, DateTime today)
    {
      var age = CalculateAge(dateOfBirth, today);

      if (age < 0)
      {
        throw new Exception("Cannot calculate age, the given birthday means the person hasn't been born yet.");
      }

      return age;
    }

    private static int CalculateAge(DateTime dateOfBirth, DateTime today)
    {
      var age = today.Year - dateOfBirth.Year;

      if (today.Month >= dateOfBirth.Month)
      {
        if (today.Day < dateOfBirth.Day)
        {
          --age;
        }
      }
      else
      {
        --age;
      }

      return age;
    }
  }
}
