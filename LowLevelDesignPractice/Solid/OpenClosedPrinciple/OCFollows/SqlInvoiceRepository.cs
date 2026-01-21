using Utilities;

namespace OC
{
    class SqlInvoiceRepository : IInvoiceRepository
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine("Logic to save invoice to Sql DB");
        }
    }
}