using System;
using NUnit.Framework;

namespace RomanNumeralsKata.Test
{
  [TestFixture]
  public class RomanNumeralsTest
  {
    [Test]
    public void GivenNumberLessThan0_ShouldThrow()
    {
      //Arrange
      const int input = -1;
      const string expected = "Please use a positive integer greater than zero.";
      var sut = CreateSut();
      //Act
      var actual = Assert.Throws<InvalidOperationException>(() =>
      {
        sut.ConvertNumberToRomanNumeral(input);
      });
      //Assert
      Assert.AreEqual(expected, actual.Message);
    }

    [Test]
    public void GivenNumber1000_ShouldReturnM()
    {
      // Arrange
      const int input = 1000;
      const string expected = "M";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber1001_ShouldReturnMI()
    {
      // Arrange
      const int input = 1001;
      const string expected = "MI";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber1199_ShouldReturnMCXCIX()
    {
      // Arrange
      const int input = 1199;
      const string expected = "MCXCIX";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber900_ShouldReturnCM()
    {
      // Arrange
      const int input = 900;
      const string expected = "CM";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber901_ShouldReturnCMI()
    {
      // Arrange
      const int input = 901;
      const string expected = "CMI";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber999_ShouldReturnCMXCIX()
    {
      // Arrange
      const int input = 999;
      const string expected = "CMXCIX";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber500_ShouldReturnD()
    {
      // Arrange
      const int input = 500;
      const string expected = "D";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber501_ShouldReturnDI()
    {
      // Arrange
      const int input = 501;
      const string expected = "DI";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber400_ShouldReturnCD()
    {
      // Arrange
      const int input = 400;
      const string expected = "CD";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber401_ShouldReturnCDI()
    {
      // Arrange
      const int input = 401;
      const string expected = "CDI";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber499_ShouldReturnCDXCIX()
    {
      // Arrange
      const int input = 499;
      const string expected = "CDXCIX";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber100_ShouldReturnC()
    {
      // Arrange
      const int input = 100;
      const string expected = "C";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber101_ShouldReturnCI()
    {
      // Arrange
      const int input = 101;
      const string expected = "CI";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber199_ShouldReturnCXCIX()
    {
      // Arrange
      const int input = 199;
      const string expected = "CXCIX";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber90_ShouldReturnXC()
    {
      // Arrange
      const int input = 90;
      const string expected = "XC";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber91_ShouldReturnXCI()
    {
      // Arrange
      const int input = 91;
      const string expected = "XCI";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber99_ShouldReturnXCIX()
    {
      // Arrange
      const int input = 99;
      const string expected = "XCIX";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber50_ShouldReturnL()
    {
      // Arrange
      const int input = 50;
      const string expected = "L";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber51_ShouldReturnLI()
    {
      // Arrange
      const int input = 51;
      const string expected = "LI";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber59_ShouldReturnLIX()
    {
      // Arrange
      const int input = 59;
      const string expected = "LIX";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber40_ShouldReturnXL()
    {
      // Arrange
      const int input = 40;
      const string expected = "XL";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber41_ShouldReturnXLI()
    {
      // Arrange
      const int input = 41;
      const string expected = "XLI";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber49_ShouldReturnXLIX()
    {
      // Arrange
      const int input = 49;
      const string expected = "XLIX";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber10_ShouldReturnX()
    {
      // Arrange
      const int input = 10;
      const string expected = "X";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber11_ShouldReturnXI()
    {
      // Arrange
      const int input = 11;
      const string expected = "XI";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber19_ShouldReturnXIX()
    {
      // Arrange
      const int input = 19;
      const string expected = "XIX";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber9_ShouldReturnIX()
    {
      // Arrange
      const int input = 9;
      const string expected = "IX";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber6_ShouldReturnVI()
    {
      // Arrange
      const int input = 6;
      const string expected = "VI";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber5_ShouldReturnV()
    {
      // Arrange
      const int input = 5;
      const string expected = "V";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber4_ShouldReturnIV()
    {
      // Arrange
      const int input = 4;
      const string expected = "IV";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber2_ShouldReturnII()
    {
      // Arrange
      const int input = 2;
      const string expected = "II";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GivenNumber1_ShouldReturnI()
    {
      // Arrange
      const int input = 1;
      const string expected = "I";
      var sut = CreateSut();
      // Act
      var actual = sut.ConvertNumberToRomanNumeral(input);
      // Assert
      Assert.AreEqual(expected, actual);
    }

    private static RomanNumerals CreateSut()
    {
      var sut = new RomanNumerals();
      return sut;
    }
  }
}
