using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CalculateAveragePattern.Test
{
  [TestFixture]
  public class TestCalculateAverageFactory
  {
    [Test]
    public void ShouldCalculateTheAverageByMean()
    {
      // Arrange
      var values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };
      var expected = Math.Round(8.3636363, 2);
      var sut = CreateSut();
      // Act
      var actual = sut.CalculatorAverageFor(values, new CalculateAverageByMean());
      // Assert
      var actualResults = Math.Round(actual, 2);
      Assert.AreEqual(expected, actualResults);
    }

    [Test]
    public void ShouldCalculateTheAverageByMedian()
    {
      // Arrange
      var values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };
      var expected = Math.Round(8.00, 2);
      var sut = CreateSut();
      // Act
      var actual = sut.CalculatorAverageFor(values, new CalculateAverageByMedian());
      // Assert
      var actualResults = Math.Round(actual, 2);
      Assert.AreEqual(expected, actualResults);
    }

    private static CalculateAverageFactory CreateSut()
    {
      var calculatorFactory = new CalculateAverageFactory();
      return calculatorFactory;
    }
  }
}
