using NUnit.Framework;

namespace MyFirstDelegate.Test
{
  [TestFixture]
  public class TestCalculationDelegate
  {
    [Test]
    public void ShouldAddNumberToTotal()
    {
      // Arrange
      const int total = 7;
      const int expected = 10;
      var sut = CreateSut(total);
      // Act
      var actual = sut.AddNumberToTotal(3);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ShouldMultiplyNumberWithTotal()
    {
      // Arrange
      const int total = 5;
      const int expected = 25;
      var sut = CreateSut(total);
      // Act
      var actual = sut.MultiplyNumberWithTotal(5);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ShouldSubtractNumberFromTotal()
    {
      // Arrange
      const int total = 15;
      const int expected = 10;
      var sut = CreateSut(total);
      // Act
      var actual = sut.SubtractNumberFromTotal(5);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    private static CalculationDelegate CreateSut(int total)
    {
      var calculationDelegate = new CalculationDelegate(total);
      return calculationDelegate;
    }
  }
}
