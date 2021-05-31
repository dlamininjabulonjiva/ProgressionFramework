using System;

namespace MyBankAccount
{
  public class BankAccount
  {
    private string _customerName;
    private double _balance;

    public BankAccount(string customerName, double balance)
    {
      _customerName = customerName;
      _balance = balance;
    }

    public double Balance
    {
      get => _balance;
      set => _balance = value;
    }

    public void Debit(double amount)
    {
      if (_balance == 0)
      {
        throw new InvalidOperationException("Your Balance is 0");
      }

      if (amount > _balance)
      {
        throw new InvalidOperationException("Amount is greater than your balance");
      }

      DebitAccount(amount);
    }

    public void Credit(double amount)
    {
      if (amount < 0)
      {
        throw new InvalidOperationException("Amount provided is less than 0");
      }

      CreditAccount(amount);
    }

    private void DebitAccount(double amount)
    {
      _balance -= amount;
    }

    private void CreditAccount(double amount)
    {
      _balance += amount;
    }
  }
}
