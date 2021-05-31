using System;
using System.Collections.Generic;
using System.Text;

namespace AccesModifiers
{
  public class PersonBirthMonth
  {
    private readonly Person _person;

    public PersonBirthMonth(Person person)
    {
      _person = person;
    }

    public int GetPersonBirthMonth()
    {
      return _person.GetBirthMonth();
    }
  }
}
