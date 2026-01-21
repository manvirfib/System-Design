using Utilities;
namespace OCFail
{
    class InvoiceRepository
    {
        public void SaveToSQLDb(Invoice invoice)
        {
            Console.WriteLine("Logic for saving to DB");
        }
        public void SaveToCosmosDb(Invoice invoice)
        {
            Console.WriteLine("Logic for saving to DB");
        }
        public void SaveToSqlLite(Invoice invoice)
        {
            Console.WriteLine("Logic for saving to DB");
        }
    }
}
// In future, if there is a new Db, we have to modify the same class (Modification of existing code that may develop more bugs)Why This Fails OCP 🚨
/*
Every new storage type → modify this class
High regression risk
Business flow polluted with infrastructure details
*/