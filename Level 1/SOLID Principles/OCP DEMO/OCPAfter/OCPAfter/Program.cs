using OCPAfter.Invoices;

namespace OCPAfter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int salesInvoiceAmount = 5000;
            var salesInvoice = InvoiceFactory.Create(InvoiceType.SalesInvoice, salesInvoiceAmount);

            const int overdueInvoiceAmount = 15000;
            var overdueInvoice = InvoiceFactory.Create(InvoiceType.OverdueInvoice, overdueInvoiceAmount);

            const int finalInvoiceAmount = 32000;
            var finalInvoice = InvoiceFactory.Create(InvoiceType.FinalInvoice, finalInvoiceAmount);

            var salesInvoiceWithDiscount = new WithDiscount(salesInvoice, 3);
            var overdueInvoiceWithDiscount = new WithDiscount(overdueInvoice, 10);
            var finalInvoiceWithDiscount = new WithDiscount(finalInvoice, 5);

            PrintInvoice(salesInvoiceWithDiscount, salesInvoiceAmount);
            PrintInvoice(overdueInvoiceWithDiscount, overdueInvoiceAmount);
            PrintInvoice(finalInvoiceWithDiscount, finalInvoiceAmount);
        }

        private static void PrintInvoice(Invoice invoice, double invoiceAmount)
        {
            Console.WriteLine("Invoice Description: " + invoice.GetDescription());
            Console.WriteLine("Invoice Amount: " + invoiceAmount);
            Console.WriteLine("Final Amount: " + invoice.Amount());
            Console.WriteLine("-----------------------------------------------------------------------------------------------------");
        }
    }
}