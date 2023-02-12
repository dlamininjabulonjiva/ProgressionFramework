using System;

namespace ISPAfter
{
    public interface ICreditCard: ICard
    {
        void CreditLimit();
        void PaymentDueDate();
        void RewardAmount();
    }
}
