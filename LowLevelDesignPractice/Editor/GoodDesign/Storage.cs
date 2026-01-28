abstract class Storage
{
    public abstract void Save(string data);
}

//Implementations
class DbStorage : Storage
{
    public override void Save(string data)
    {
        Console.Write("Saved to db");
    }
}

class CosmosStorage : Storage
{
    public override void Save(string data)
    {
        Console.Write("Saved to cosmos");
    }
}

class FileStorage : Storage
{
    string path = "/Users/shredder/Desktop/output.txt";
    public override void Save(string data)
    {
        using (StreamWriter sw = new(path))
        {
            sw.WriteLine(data);
        }
    }
}