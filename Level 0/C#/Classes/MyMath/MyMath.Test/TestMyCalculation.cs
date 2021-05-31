using NUnit.Framework;

namespace MyMath.Test
{
  [TestFixture]
  public class TestMyCalculation
  {
    [Test]
    public void ShouldAddTheSumOfTheInputsToTotal()
    {
      // Arrange
      const int input1 = 3;
      const int input2 = 5;
      const int expected = 15;
      var sut = CreateSut(7);
      // Act
      sut.AddSumToTotal(input1, input2);
      // assert
      Assert.AreEqual(expected, sut.Total);
    }

    [Test]
    public void ShouldAddTheDifferenceOfTheInputsToTotal()
    {
      // Arrange
      const int input1 = 5;
      const int input2 = 3;
      const int expected = 10;
      var sut = CreateSut(8);
      // Act
      sut.AddDifferenceToTotal(input1, input2);
      // assert
      Assert.AreEqual(expected, sut.Total);
    }

    [Test]
    public void ShouldAddTheMultiplicationOfTheInputsToTotal()
    {
      // Arrange
      const int input1 = 5;
      const int input2 = 3;
      const int expected = 17;
      var sut = CreateSut(2);
      // Act
      sut.AddMultiplicationToTotal(input1, input2);
      // assert
      Assert.AreEqual(expected, sut.Total);
    }
    
    [Test]
    public void ShouldAddTheDivisionOfTheInputsToTotal()
    {
      // Arrange
      const int input1 = 10;
      const int input2 = 2;
      const int expected = 10;
      var sut = CreateSut(5);
      // Act
      sut.AddDivisionToTotal(input1, input2);
      // assert
      Assert.AreEqual(expected, sut.Total);
    }

    private static MyCalculation CreateSut(int total)
    {
      var myCalculation = new MyCalculation(total);
      return myCalculation;
    }
  }
}
