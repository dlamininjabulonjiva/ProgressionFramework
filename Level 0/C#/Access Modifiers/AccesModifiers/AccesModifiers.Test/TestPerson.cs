using System;
using NUnit.Framework;

namespace AccesModifiers.Test
{
  [TestFixture]
  public class TestPerson
  {
    [Test]
    public void ShouldReturnTheDateOfBirth()
    {
      // Arrange
      var dateOfBirth = new DateTime(1993, 06, 15);
      var sut = CreateSut(dateOfBirth);
      // Act
      var actual = sut.GetDateOfBirth();
      // Assert
      Assert.AreEqual(dateOfBirth, actual);
    }

    private static Person CreateSut(DateTime dateOfBirth)
    {
      var person = new Person(dateOfBirth);
      return person;
    }
  }
}
