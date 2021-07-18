using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace StringCalculatorKata.Test
{
  [TestFixture]
  public class StringCalculatorTest
  {
    [Test]
    public void GivenNoNumbers_ShouldReturn0()
    {
      // Arrange
      const string input = "";
      const int expected = 0;
      var sut = CreateSut();
      // Act
      var actual = sut.Add(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Given1Numbers_ShouldReturnSameNumber()
    {
      // Arrange
      const string input = "5";
      const int expected = 5;
      var sut = CreateSut();
      // Act
      var actual = sut.Add(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumbersCommaDelimited_ShouldBeSummed()
    {
      // Arrange
      const string input = "5,10";
      const int expected = 15;
      var sut = CreateSut();
      // Act
      var actual = sut.Add(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumbersNewLineDelimited_ShouldBeSummed()
    {
      // Arrange
      const string input = "11\n13";
      const int expected = 24;
      var sut = CreateSut();
      // Act
      var actual = sut.Add(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumbersDelimitedAnyway_ShouldBeSummed()
    {
      // Arrange
      const string input = "11\n13,2%4";
      const int expected = 30;
      var sut = CreateSut();
      // Act
      var actual = sut.Add(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNegativeInput_ShouldThrow()
    {
      // Arrange
      const string input = "-1";
      const string expected = "Negatives not allowed";
      var sut = CreateSut();
      // Act
      var result = Assert.Throws<InvalidOperationException>(() =>
      {
        sut.Add(input);
      });
      // Assert
      if (result != null) Assert.AreEqual(expected, result.Message);
    }

    [Test]
    public void GivenNumbersGreaterThan1000_ShouldBeIgnored()
    {
      // Arrange
      const string input = "11\n13,2%4,1200,1500,1300";
      const int expected = 30;
      var sut = CreateSut();
      // Act
      var actual = sut.Add(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    private static StringCalculator CreateSut()
    {
      var sut = new StringCalculator();
      return sut;
    }
  }
}
