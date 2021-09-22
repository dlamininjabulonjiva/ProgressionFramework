using System;
using NUnit.Framework;

namespace AgeCalculatorKata.Test
{
  [TestFixture]
  public class AgeCalculatorTest
  {
    [TestFixture]
    public class BornOnALeapYear
    {
      [TestFixture]
      public class BornOn29February
      {
        [Test]
        public void GivenTodayIs29February_ShouldIncrementAgeBy1()
        {
          // Arrange
          var dateOfBirth = new DateTime(1992, 02, 29);
          var targetDate = new DateTime(2020, 02, 29);
          const int expected = 28;
          var sut = CreateSut();
          // Act
          var actual = sut.Calculate(dateOfBirth, targetDate);
          // assert
          Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenTodayIs28February_ShouldIncrementAgeBy1()
        {
          // Arrange
          var dateOfBirth = new DateTime(1992, 02, 29);
          var targetDate = new DateTime(2021, 02, 28);
          const int expected = 29;
          var sut = CreateSut();
          // Act
          var actual = sut.Calculate(dateOfBirth, targetDate);
          // assert
          Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenTodayIs27February_ShouldReturnCurrentAge()
        {
          // Arrange
          var dateOfBirth = new DateTime(1992, 02, 29);
          var targetDate = new DateTime(2021, 02, 27);
          const int expected = 28;
          var sut = CreateSut();
          // Act
          var actual = sut.Calculate(dateOfBirth, targetDate);
          // assert
          Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenTodayIs1March_ShouldIncrementAgeBy1()
        {
          // Arrange
          var dateOfBirth = new DateTime(1992, 02, 29);
          var targetDate = new DateTime(2021, 03, 01);
          const int expected = 29;
          var sut = CreateSut();
          // Act
          var actual = sut.Calculate(dateOfBirth, targetDate);
          // assert
          Assert.AreEqual(expected, actual);
        }
      }

      [TestFixture]
      public class BornOnNormalDays
      {
        [Test]
        public void GivenIAmBornToday_ShouldReturn0()
        {
          // Arrange
          var dateOfBirth = new DateTime(2020, 01, 01);
          var targetDate = new DateTime(2020, 01, 01);
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
          var dateOfBirth = new DateTime(1992, 02, 28);
          var targetDate = new DateTime(2021, 02, 28);
          const int expected = 29;
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
          var dateOfBirth = new DateTime(1992, 02, 02);
          var targetDate = new DateTime(2021, 02, 01);
          const int expected = 28;
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
          var dateOfBirth = new DateTime(1992, 03, 01);
          var targetDate = new DateTime(2021, 03, 02);
          const int expected = 29;
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
          var dateOfBirth = new DateTime(1992, 02, 17);
          var targetDate = new DateTime(2021, 01, 17);
          const int expected = 28;
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
          var dateOfBirth = new DateTime(1992, 01, 01);
          var targetDate = new DateTime(2021, 02, 01);
          const int expected = 29;
          var sut = CreateSut();
          // Act
          var actual = sut.Calculate(dateOfBirth, targetDate);
          // assert
          Assert.AreEqual(expected, actual);
        }
      }
    }

    [TestFixture]
    public class BornOnANormalYear
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
