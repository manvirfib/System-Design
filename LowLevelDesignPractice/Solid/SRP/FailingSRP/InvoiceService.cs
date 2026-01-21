using System.Net.Mail;
using Utilities;

namespace SRPFail
{
    class InvoiceService
    {
        public void CreateInvoice()
        {
            //Invoice created
            var invoice = new Invoice { Amount = 2000, InvoiceName = "FirstInvoice" };

            //Save to db
            var db = new DB(); //SqlConnection
            db.Save(invoice);

            // Email
            SmtpClient client = new SmtpClient("smptp.company.com");
            client.Send("billing@company.com","sdsd@mail.com", "invoice Created", "Invoice Attached");
        }
    }
}
// A company generates invoices, saves them, emails customers, and logs audit info.
// Someone decides to put everything in one service.