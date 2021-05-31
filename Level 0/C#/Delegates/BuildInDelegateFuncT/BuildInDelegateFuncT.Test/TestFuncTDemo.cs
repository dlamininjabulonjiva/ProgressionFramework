using NUnit.Framework;

namespace BuildInDelegateFuncT.Test
{
  [TestFixture]
  public class TestFuncTDemo
  {
    [Test]
    public void ShouldReturnTheSquareOfANumber()
    {
      // Arrange
      const double number = 4;
      const double expected = 16;
      var sut = CreateSut(number);
      // Act
      var actual = sut.GetSquare();
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ShouldReturnTheCubeOfANumber()
    {
      // Arrange
      const double number = 5;
      const double expected = 125;
      var sut = CreateSut(number);
      // Act
      var actual = sut.GetCube();
      // Assert
      Assert.AreEqual(expected, actual);
    }

    private static FuncTDemo CreateSut(double number)
    {
      var funcTDemo = new FuncTDemo(number);
      return funcTDemo;
    }
  }
}
