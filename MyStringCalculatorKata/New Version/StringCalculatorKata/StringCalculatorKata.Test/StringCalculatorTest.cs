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
    public void Given1Number_ShouldReturnSameNumber()
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
    public void Given2NumbersCommaDelimited_ShouldBeSummed()
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
    public void GivenMultipleNumbersCommaDelimited_ShouldBeSummed()
    {
      // Arrange
      const string input = "5,10,2,3,15";
      const int expected = 35;
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
    public void GivenDifferentDelimiter_ShouldSum()
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
    public void GivenNegativeNumber_ShouldThrow()
    {
      // Arrange
      const string input = "//;\n1;-2";
      const string expected = "Negatives not allowed -2";
      var sut = CreateSut();
      // Act
      var result = Assert.Throws<InvalidOperationException>(() =>
      {
        sut.Add(input);
      });
      // Assert
      Assert.AreEqual(expected, result.Message);
    }

    [Test]
    public void GivenNegativeNumbers_ShouldThrow()
    {
      // Arrange
      const string input = "//;\n1;-2,1,-5,-8";
      const string expected = "Negatives not allowed -2,-5,-8";
      var sut = CreateSut();
      // Act
      var result = Assert.Throws<InvalidOperationException>(() =>
      {
        sut.Add(input);
      });
      // Assert
      Assert.AreEqual(expected, result.Message);
    }

    [Test]
    public void GivenNumbersGreaterThan1000_ShouldBeIgnored()
    {
      // Arrange
      const string input = "1\n2,1000,1001";
      const int expected = 1003;
      var sut = CreateSut();
      // Act
      var actual = sut.Add(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenDelimitersLongerThanOneCharacter_ShouldSum()
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
    public void GivenMultipleDelimiters_ShouldSum()
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

    [Test]
    public void GivenMultipleDelimitersWithDifferentLengths_ShouldSum()
    {
      // Arrange
      const string input = "//[AAA][b]\n7,2AAA3";
      const int expected = 12;
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
