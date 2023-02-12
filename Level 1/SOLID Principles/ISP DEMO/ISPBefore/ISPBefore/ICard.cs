using System;

namespace ISPBefore
{
    public interface ICard
    {
        void CardNumber();
        void CardFee();
        void ExpiryDate();
        void CardPin();

        //Now the following are not applicable to debit card, but rather applicable to credit card
        void CreditLimit();
        void PaymentDueDate();
        void RewardAmount();
    }
}
