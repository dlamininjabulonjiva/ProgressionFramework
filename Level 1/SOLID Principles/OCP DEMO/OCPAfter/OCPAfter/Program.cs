using OCPAfter.Invoices;

namespace OCPAfter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int salesInvoiceAmount = 5000;
            Invoice salesInvoice = new SalesInvoice(salesInvoiceAmount);

            const int overdueInvoiceAmount = 15000;
            Invoice overdueInvoice = new OverdueInvoice(overdueInvoiceAmount);

            const int finalInvoiceAmount = 32000;
            Invoice finalInvoice = new FinalInvoice(finalInvoiceAmount);

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