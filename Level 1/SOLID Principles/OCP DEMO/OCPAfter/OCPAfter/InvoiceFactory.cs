using OCPAfter.Invoices;

namespace OCPAfter
{
    public class InvoiceFactory
    {
        private InvoiceFactory(){}
        public static Invoice Create(InvoiceType type, double amount)
        {
            switch (type)
            {
                case InvoiceType.FinalInvoice:
                    return new FinalInvoice(amount);
                case InvoiceType.OverdueInvoice:
                    return new OverdueInvoice(amount);
                case InvoiceType.SalesInvoice:
                    return new SalesInvoice(amount);
                default:
                    return new SalesInvoice(amount);
            }
        }
    }
}
