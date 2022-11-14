using System;

namespace OCPAfter
{
    public abstract class Invoice
    {
        public abstract string GetDescription();
        public abstract double Amount();
    }
}
