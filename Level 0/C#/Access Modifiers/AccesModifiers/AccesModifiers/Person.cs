using System;
using System.Collections.Generic;
using System.Text;

namespace AccesModifiers
{
  public class Person
  {
    //this dateOfBirth field can only be accessed inside this Person class
    private readonly DateTime _dateOfBirth;

    //This Person constructor can be accessed by any code inside this assembly or any assembly that references it
    public Person(DateTime dateOfBirth)
    {
      _dateOfBirth = dateOfBirth;
    }

    //This GetDateOfBirth method can be accessed by any code inside this assembly or any assembly that references it
    public DateTime GetDateOfBirth()
    {
      return _dateOfBirth;
    }

    // This internal method is only accessible within this assembly
    internal int GetBirthMonth()
    {
      return _dateOfBirth.Month;
    }
  }
}
