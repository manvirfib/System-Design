using Utilities;

namespace OC
{
    class CosmosDbInvoiceRepository : IInvoiceRepository
    {
        public void Save(Invoice invoice)
        {
            Console.WriteLine("Logic to save invoice to Cosmos DB");
        }
    }
}