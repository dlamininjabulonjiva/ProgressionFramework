using NUnit.Framework;

namespace BuildInDelegateActionT.Test
{
  [TestFixture]
  public class TestActionTDemo
  {
    [Test]
    public void ShouldReturnTheSquareOfANumber()
    {
      // Arrange
      const double number = 4;
      const double expected = 16;
      var sut = CreateSut(number);
      // Act
      sut.GetSquare();
      // Assert
      Assert.AreEqual(expected, sut.Number);
    }

    [Test]
    public void ShouldReturnTheCubeOfANumber()
    {
      // Arrange
      const double number = 5;
      const double expected = 125;
      var sut = CreateSut(number);
      // Act
      sut.GetCube();
      // Assert
      Assert.AreEqual(expected, sut.Number);
    }

    private static ActionTDemo CreateSut(double number)
    {
      var actionTDemo = new ActionTDemo(number);
      return actionTDemo;
    }
  }
}
