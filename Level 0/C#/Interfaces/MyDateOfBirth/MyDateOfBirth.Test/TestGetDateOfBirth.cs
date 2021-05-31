using System;
using MyDateOfBirth.Test.TestDataBuilder;
using NUnit.Framework;

namespace MyDateOfBirth.Test
{
  [TestFixture]
  public class TestGetDateOfBirth
  {
    [TestCase("")]
    [TestCase(null)]
    [TestCase("9385155714084")]
    [TestCase("19302205714084")]
    public void GivenInvalidIdentityNumber_ShouldReturnNull(string identityNumber)
    {
      // Arrange
      var sut = new GetDateOfBirthTestDataBuilder()
        .WithDateOfBirthReturning(identityNumber, null)
        .Build();
      // Act
      var actual = sut.GetDateOfBirthFromIdNumber(identityNumber);
      // Assert
      Assert.AreEqual(null, actual);
    }

    [TestCase("9304135714084")]
    [TestCase("9206258702082")]
    [TestCase("9312253712084")]
    public void GivenValidIdentityNumber_ShouldReturnDateOfBirth(string identityNumber)
    {
      // Arrange
      var year = Convert.ToInt32(identityNumber.Substring(0, 2));
      var month = Convert.ToInt32(identityNumber.Substring(2, 2));
      var day = Convert.ToInt32(identityNumber.Substring(4, 2));

      var expectedDateOfBirth = new DateTime(year, month, day);

      var sut = new GetDateOfBirthTestDataBuilder()
        .WithDateOfBirthReturning(identityNumber, expectedDateOfBirth)
        .Build();
      // Act
      var actual = sut.GetDateOfBirthFromIdNumber(identityNumber);
      // Assert
      Assert.AreEqual(expectedDateOfBirth, actual);
    }
  }
}
