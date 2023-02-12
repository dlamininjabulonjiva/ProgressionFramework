using System;

namespace ISPAfter
{
    public class CreditCard: ICreditCard
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

        public void CreditLimit()
        {
            Console.WriteLine("Your credit limit is: .......");
        }

        public void PaymentDueDate()
        {
            Console.WriteLine("Your payment due date is: .......");
        }

        public void RewardAmount()
        {
            Console.WriteLine("Your reward amount is: .......");
        }
    }
}
