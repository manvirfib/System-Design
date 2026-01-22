namespace failingDIP
{
    class InvoiceService
    {
        MySql mySql;
        CosmosDb cosmosDb;
        public InvoiceService()
        {
            mySql = new();
            cosmosDb = new();
        }
        public void SaveToSql(string data)
        {
            mySql.SaveToSql(data);
        }
        public void SaveToCosmosDb(string data)
        {
            cosmosDb.SaveToCosmosDb(data);
        }
    }
}
// Above code shows InvoiceService class is dependent on the low level modules MySql and CosmosDb
// And In future, if there comes a new Db, we have to chance the business layer again, 
