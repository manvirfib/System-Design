class DocumentEditor
{
    Document document;
    Storage storage;
    string renderedScreen;
    public DocumentEditor(Document doc, Storage storage)
    {
        document = doc;
        this.storage = storage;
        renderedScreen = "";
    }
    public void AddText(string text)
    {
        document.AddElement(new TextElement(text));
    }
    public void AddImage(string path)
    {
        document.AddElement(new ImageElement(path));
    }
    public void AddLine()
    {
        document.AddElement(new NextLineElement());
    }
    public void AddTab()
    {
        document.AddElement(new TabElement());
    }
    public string Render()
    {
        return renderedScreen = document.Render();
    }
    public void SaveToDb()
    {
        storage.Save(renderedScreen);
    }
    public void SaveToFile()
    {
        storage.Save(renderedScreen);
    }
}