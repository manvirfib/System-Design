using Utilities;

namespace OC
{
    class InvoiceService
    {
        readonly IInvoiceRepository _repo;
        public InvoiceService(IInvoiceRepository repo)
        {
            _repo = repo;
        }
        public void SaveInvoice(Invoice invoice)
        {
            _repo.Save(invoice);
        }
    }
}
// Now adding new storage type is easy, just create a new class and extend the interface, we are not modifying the existing code.