using System;

namespace ISPBefore
{
    public class DebitCard : ICard
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

        //ISP is violated here cos the following implementations are not required in the debit card
        public void CreditLimit()
        {
            throw new NotSupportedException("Debit cards do not have credit limit");
        }

        public void PaymentDueDate()
        {
            throw new NotSupportedException("Debit cards do not have payment due date");
        }

        public void RewardAmount()
        {
            throw new NotSupportedException("Debit cards do not have reward amount");
        }
    }
}
