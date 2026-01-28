using Editor;

class Program
{
    static void Main()
    {
        // ///////////////////////////////////////////////////////
        //  GoogleDocs Bad Design
        // ///////////////////////////////////////////////////////
        // DocumentEditor documentEditor = new();
        // documentEditor.AddText("This is a working example \n");
        // documentEditor.AddImage("Hello.jpg");
        // documentEditor.Render();
        // documentEditor.SaveToFile();

        // ///////////////////////////////////////////////////////
        //  GoogleDocs Good Design
        // ///////////////////////////////////////////////////////
        DocumentEditor documentEditor = new(new Document(), new FileStorage());
        documentEditor.AddText("This is my first ever low level design.");
        documentEditor.AddLine();
        documentEditor.AddText("We have tabs");
        documentEditor.AddTab();
        documentEditor.AddTab();
        documentEditor.AddText("<--Here");
        documentEditor.Render();
        documentEditor.SaveToFile();
    }
}