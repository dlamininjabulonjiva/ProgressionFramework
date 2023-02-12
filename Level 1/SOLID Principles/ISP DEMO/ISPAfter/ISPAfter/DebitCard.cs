using System;

namespace ISPAfter
{
    public class DebitCard: IDebitCard
    {
        public void CardFee()
        {
            Console.WriteLine("Your card fee is: .........");
        }

        public void CardNumber()
        {
            Console.WriteLine("Your card number is: .......");
        }

        public void CardPin()
        {
            Console.WriteLine("Your card pin is: .......");
        }

        public void ExpiryDate()
        {
            Console.WriteLine("Your card expiry date is: .......");
        }

        public void BalanceAmount()
        {
            Console.WriteLine("Your balance amount is: .......");
        }
    }
}
