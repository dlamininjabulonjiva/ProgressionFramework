using System;
using NUnit.Framework;

namespace AgeCalculatorKata.Test
{
  [TestFixture]
  public class AgeCalculatorTest
  {
    [Test]
    public void GivenPersonIsBornToday_ShouldReturnCurrentAgeAs0()
    {
      // Arrange
      var dateOfBirth = new DateTime(2017, 01, 01);
      var targetDate = new DateTime(2017, 01, 01);
      const int expected = 0;
      var sut = CreateSut();
      // Act
      var actual = sut.Calculate(dateOfBirth, targetDate);
      // assert
      Assert.AreEqual(expected, actual);
    }

    [TestCase("1993-06-15", "2021-06-15", 28)]
    [TestCase("1978-04-9", "2020-04-9", 42)]
    [TestCase("1999-07-31", "2021-07-31", 22)]
    public void GivenBirthdayIsCelebratedToday_ShouldReturnCurrentAgePlusOne(DateTime dateOfBirth, DateTime targetDate, int expected)
    {
      //Arrange
      var sut = CreateSut();
      //Act
      var actual = sut.Calculate(dateOfBirth, targetDate);
      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestCase("1995-10-12", "2021-10-11", 25)]
    [TestCase("1993-04-9", "2021-04-8", 27)]
    [TestCase("2001-03-15", "2021-03-14", 19)]
    public void GivenBirthdayIsOneDayAway_ShouldReturnCurrentAge(DateTime dateOfBirth, DateTime targetDate, int expected)
    {
      //Arrange
      var sut = CreateSut();
      //Act
      var actual = sut.Calculate(dateOfBirth, targetDate);
      //Assert
      Assert.AreEqual(expected, actual);
    }

    [TestCase("1995-10-12", "2021-9-12", 25)]
    [TestCase("1980-05-9", "2021-5-9", 41)]
    [TestCase("1991-07-31", "2021-06-30", 29)]
    public void GivenBirthdayIsOneMonthAway_ShouldReturnCurrentAge(DateTime dateOfBirth, DateTime targetDate, int expected)
    {
      //Arrange
      var sut = CreateSut();
      //Act
      var actual = sut.Calculate(dateOfBirth, targetDate);
      //Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenPersonIsYetToBeBorn_ShouldThrow()
    {
      //Arrange
      var dateOfBirth = new DateTime(2022, 06, 15);
      var targetDate = new DateTime(2022, 01, 01);
      const string expected = "Cannot calculate age, the given birthday means the person hasn't been born yet.";
      var sut = CreateSut();
      //Act
      var actual = Assert.Throws<Exception>(() =>
      {
        sut.Calculate(dateOfBirth, targetDate);
      });
      //Assert
      Assert.AreEqual(expected, actual.Message);
    }

    private static AgeCalculator CreateSut()
    {
      var sut = new AgeCalculator();
      return sut;
    }
  }
}
