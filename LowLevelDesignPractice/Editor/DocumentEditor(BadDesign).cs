namespace Editor
{
    class DocumentEditor
    {
        List<string> elements;
        string filePath;
        public DocumentEditor()
        {
            elements = new();
            filePath = "/Users/shredder/Desktop/output.txt";
        }
        public void AddText(string data)
        {
            elements.Add(data);
        }
        public void AddImage(string path)
        {
            elements.Add(path);
        }
        public void Render()
        {
            foreach (var element in elements)
            {
                if (IsImage(element))
                {
                    Console.WriteLine("It is an image");
                }
                else
                {
                    Console.WriteLine("It is a text");
                }
            }
            Console.WriteLine();
        }
        bool IsImage(string data)
        {
            if (data.Length > 4 && data.EndsWith(".jpg"))
            {
                return true;
            }
            return false;
        }
        public void SaveToFile()
        {
            using (StreamWriter writer = new(filePath))
            {
                foreach (var element in elements)
                {
                    writer.WriteLine(element);
                }
            }
        }
    }
}