using Utilities;

namespace OC
{
    class SqliteRepository : IInvoiceRepository
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine("Logic to save invoice to Sqlite DB");
        }
    }
}