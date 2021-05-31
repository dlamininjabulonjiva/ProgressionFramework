using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace AccesModifiers.Test
{
  [TestFixture]
  public class TestPersonBirthMonth
  {
    [Test]
    public void ShouldReturnPersonBirthMonth()
    {
      // Arrange
      var dateOfBirth = new DateTime(1993, 06, 15);
      var person =  new Person(dateOfBirth);
      var sut = CreateSut(person);
      // Act
      var actual = sut.GetPersonBirthMonth();
      // Assert
      Assert.AreEqual(dateOfBirth.Month, actual);
    }

    private static PersonBirthMonth CreateSut(Person person)
    {
      var sut = new PersonBirthMonth(person);
      return sut;
    }
  }
}
