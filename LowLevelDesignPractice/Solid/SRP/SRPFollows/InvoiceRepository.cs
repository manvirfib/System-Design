using Utilities;

namespace SRP
{
    class InvoiceRepository
    {
        public void SaveToDb(Invoice invoice)
        {
            DB dB = new DB();
            dB.Save(invoice);
        }
    }
}