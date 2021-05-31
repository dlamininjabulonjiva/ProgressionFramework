using System;
using NUnit.Framework;

namespace MyBankAccount.Test
{
  [TestFixture]
  public class TestBankAccount
  {
    [TestFixture]
    public class Debit
    {
      [Test]
      public void GivenBalanceIs0_ShouldThrow()
      {
        // Arrange
        const string customerName = "Elvis";
        const double balance = 0;
        const string expected = "Your Balance is 0";
        var sut = CreateSut(customerName, balance);
        // Act
        var result = Assert.Throws<InvalidOperationException>(() =>
        {
          sut.Debit(200);
        });
        // Assert
        if (result != null) Assert.AreEqual(expected, result.Message);
      }

      [Test]
      public void GivenAmountGreaterThanBalance_ShouldThrow()
      {
        // Arrange
        const string customerName = "Elvis";
        const double balance = 500;
        const string expected = "Amount is greater than your balance";
        var sut = CreateSut(customerName, balance);
        // Act
        var result = Assert.Throws<InvalidOperationException>(() =>
        {
          sut.Debit(600);
        });
        // Assert
        if (result != null) Assert.AreEqual(expected, result.Message);
      }

      [Test]
      public void GivenBalanceIsGreaterThanProvidedAmount_ShouldDebitTheAccount()
      {
        // Arrange
        const string customerName = "Elvis";
        const double balance = 500;
        const double expected = 300;
        var sut = CreateSut(customerName, balance);
        // Act
        sut.Debit(200);
        // Assert
        Assert.AreEqual(expected, sut.Balance);
      }
    }

    [TestFixture]
    public class Credit
    {
      [Test]
      public void GivenAmountIsLessThan0_ShouldThrow()
      {
        // Arrange
        const string customerName = "Elvis";
        const double balance = 50;
        const string expected = "Amount provided is less than 0";
        var sut = CreateSut(customerName, balance);
        // Act
        var result = Assert.Throws<InvalidOperationException>(() =>
        {
          sut.Credit(-1);
        });
        // Assert
        if (result != null) Assert.AreEqual(expected, result.Message);
      }

      [Test]
      public void GivenAmountIsNotLessThan0_ShouldCreditTheAccount()
      {
        // Arrange
        const string name = "Elvis";
        const double balance = 500;
        const double expected = 700;
        var sut = CreateSut(name, balance);
        // Act
        sut.Credit(200);
        // Assert
        Assert.AreEqual(expected, sut.Balance);
      }
    }
    
    private static BankAccount CreateSut(string customerName, double balance)
    {
      var bankAccount = new BankAccount(customerName, balance);
      return bankAccount;
    }
  }
}
