using System;

namespace CodeThatConformsToSRP.UseAccount
{
    public class AccountDetails
    {
        public void DisplayAccountDetails(Account account)
        {
            Console.WriteLine($"Username: { account.Username} Password: { account.Password}" +
                              $" Id Number: { account.IdNumber } Opening Balance: { account.OpeningBalance } ");
        }
    }
}
