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

      age = !DateTime.IsLeapYear(dateOfBirth.Year) ? GetAgeIfBornInANormalYear(dateOfBirth, today, age) : GetAgeIfBornInALeapYear(dateOfBirth, today, age);

      return age;
    }

    private static int GetAgeIfBornInANormalYear(DateTime dateOfBirth, DateTime today, int age)
    {
      if (today.Month >= dateOfBirth.Month)
      {
        age = GetAge(dateOfBirth, today, age);
      }
      else
      {
        --age;
      }

      return age;
    }

    private static int GetAgeIfBornInALeapYear(DateTime dateOfBirth, DateTime today, int age)
    {
      if (!DateTime.IsLeapYear(today.Year))
      {
        if (today.Month >= dateOfBirth.Month)
        {
          age = today.Month switch
          {
            2 => GetAge(dateOfBirth, today, age, 28),
            3 => GetAge(dateOfBirth, today, age, 1),
            _ => GetAge(dateOfBirth, today, age)
          };
        }
        else
        {
          --age;
        }
      }

      return age;
    }

    private static int GetAge(DateTime dateOfBirth, DateTime today, int age)
    {
      if (today.Day < dateOfBirth.Day)
      {
        --age;
      }

      return age;
    }

    private static int GetAge(DateTime dateOfBirth, DateTime today, int age, int day)
    {
      if (today.Day < dateOfBirth.Day && today.Day != day)
      {
        --age;
      }

      return age;
    }
  }
}
