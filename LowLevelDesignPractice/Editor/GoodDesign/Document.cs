class Document
{
    List<DocumentElement> elements;
    public Document()
    {
        elements = new();
    }
    public void AddElement(DocumentElement element)
    {
        elements.Add(element);
    }
    public string Render()
    {
        string renderScreen = "";
        foreach(var ele in elements)
        {
            renderScreen += ele?.Render();
        }
        return renderScreen;
    }
}