using System;

namespace OCPAfter
{
    public abstract class InvoiceDecorator: Invoice
    {
        public abstract override string GetDescription();
    }
}
