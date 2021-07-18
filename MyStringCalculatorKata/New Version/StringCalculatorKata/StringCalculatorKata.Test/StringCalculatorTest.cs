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
      const string input = "5,10,2";
      const int expected = 17;
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
      const string input = "11\n13\n1";
      const int expected = 25;
      var sut = CreateSut();
      // Act
      var actual = sut.Add(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenDifferentDelimiter_ShouldBeSummed()
    {
      // Arrange
      const string input = "//;\n1;2";
      const int expected = 3;
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
      const string input = "-1, -5";
      const string expected = "Negatives not allowed -1,-5";
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
      const string input = "1,1002";
      const int expected = 1;
      var sut = CreateSut();
      // Act
      var actual = sut.Add(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenDelimitersLongerThanOneCharacter_ShouldBeSummed()
    {
      // Arrange
      const string input = "//AAA\n1AAA2AAA3";
      const int expected = 6;
      var sut = CreateSut();
      // Act
      var actual = sut.Add(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenMultipleDelimiters_ShouldBeSummed()
    {
      // Arrange
      const string input = "//[A][b]\n1A2b3";
      const int expected = 6;
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
