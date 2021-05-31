using NUnit.Framework;

namespace MyCalculation.Test
{
  [TestFixture]
  public class TestCalculationFactory
  {
    [Test]
    public void ShouldReturnTheSumOfTwoNumber()
    {
      // Arrange
      const int num1 = 10;
      const int num2 = 5;
      const int expected = 15;

      var calculationFactory = CalculationFactory.GetCalculator(Operator.Add);
      // Act
      var actual = calculationFactory.CalculationFor(num1, num2);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ShouldReturnTheDifferenceOfTwoNumber()
    {
      // Arrange
      const int num1 = 10;
      const int num2 = 5;
      const int expected = 5;

      var calculationFactory = CalculationFactory.GetCalculator(Operator.Subtract);
      // Act
      var actual = calculationFactory.CalculationFor(num1, num2);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ShouldReturnTheProductForTwoNumber()
    {
      // Arrange
      const int num1 = 10;
      const int num2 = 5;
      const int expected = 50;

      var calculationFactory = CalculationFactory.GetCalculator(Operator.Multiply);
      // Act
      var actual = calculationFactory.CalculationFor(num1, num2);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ShouldReturnTheQuotientOfTwoNumber()
    {
      // Arrange
      const int num1 = 10;
      const int num2 = 5;
      const int expected = 2;

      var calculationFactory = CalculationFactory.GetCalculator(Operator.Divide);
      // Act
      var actual = calculationFactory.CalculationFor(num1, num2);
      // Assert
      Assert.AreEqual(expected, actual);
    }
  }
}
