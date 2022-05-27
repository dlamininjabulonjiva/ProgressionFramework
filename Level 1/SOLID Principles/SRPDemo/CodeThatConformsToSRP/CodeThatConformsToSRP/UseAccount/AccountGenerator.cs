using System;

namespace CodeThatConformsToSRP.UseAccount
{
    public class AccountGenerator
    {
        public Account Create(Person.Person user)
        {
            var random = new Random();

            var account = new Account()
            {
                Username = user.FirstName?.Substring(0, 1) + user.LastName,
                IdNumber = user.IdNumber,
                Password = user.FirstName + user.FirstName?.Length,
                OpeningBalance = random.Next(100, 15000)
            };

            return account;
        }
    }
}
