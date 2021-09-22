using System;
using NUnit.Framework;

namespace AgeCalculatorKata.Test
{
  [TestFixture]
  public class AgeCalculatorTest
  {
    [Test]
    public void GivenIAmBornToday_ShouldReturn0()
    {
      // Arrange
      var dateOfBirth = new DateTime(2021, 01, 01);
      var targetDate = new DateTime(2021, 01, 01);
      const int expected = 0;
      var sut = CreateSut();
      // Act
      var actual = sut.Calculate(dateOfBirth, targetDate);
      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenMyBirthdayIsToday_ShouldIncrementAgeBy1()
    {
      // Arrange
      var dateOfBirth = new DateTime(1993, 01, 01);
      var targetDate = new DateTime(2021, 01, 01);
      const int expected = 28;
      var sut = CreateSut();
      // Act
      var actual = sut.Calculate(dateOfBirth, targetDate);
      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenMyBirthdayIsTomorrow_ShouldReturnCurrentAge()
    {
      // Arrange
      var dateOfBirth = new DateTime(1993, 01, 02);
      var targetDate = new DateTime(2021, 01, 01);
      const int expected = 27;
      var sut = CreateSut();
      // Act
      var actual = sut.Calculate(dateOfBirth, targetDate);
      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenMyBirthdayWasYesterday_ShouldIncrementAgeBy1()
    {
      // Arrange
      var dateOfBirth = new DateTime(1993, 01, 01);
      var targetDate = new DateTime(2021, 01, 02);
      const int expected = 28;
      var sut = CreateSut();
      // Act
      var actual = sut.Calculate(dateOfBirth, targetDate);
      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenMyBirthdayIsInAMonthFromNow_ShouldReturnCurrentAge()
    {
      // Arrange
      var dateOfBirth = new DateTime(1993, 02, 01);
      var targetDate = new DateTime(2021, 01, 01);
      const int expected = 27;
      var sut = CreateSut();
      // Act
      var actual = sut.Calculate(dateOfBirth, targetDate);
      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenMyBirthdayWasAMonthAgo_ShouldIncrementAgeBy1()
    {
      // Arrange
      var dateOfBirth = new DateTime(1993, 01, 01);
      var targetDate = new DateTime(2021, 02, 01);
      const int expected = 28;
      var sut = CreateSut();
      // Act
      var actual = sut.Calculate(dateOfBirth, targetDate);
      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenIAmYetToBeBorn_ShouldThrow()
    {
      //Arrange
      var dateOfBirth = new DateTime(2022, 06, 15);
      var targetDate = new DateTime(2021, 01, 01);
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
