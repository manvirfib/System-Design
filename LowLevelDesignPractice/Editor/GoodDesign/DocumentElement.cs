abstract class DocumentElement
{
    public abstract string Render();
}

// Implementation of the abstract class
class TextElement : DocumentElement
{
    private string Data { get; }
    public TextElement(string data)
    {
        this.Data = data;
    }
    public override string Render()
    {
        return Data;
    }
}

class ImageElement : DocumentElement
{
    string path { get; }
    public ImageElement(string path)
    {
        this.path = path;
    }
    public override string Render()
    {
        string imageForm = "";
        if(path.Length > 4 && path.EndsWith(".jpg"))
        {
            imageForm = $"[Image with type: { path.Substring(path.Length - 4, 4) }";
        }
        return imageForm;
    }
}
class TabElement : DocumentElement
{
    public override string Render()
    {
        string textForm = "    ";
        return textForm;
    }
}
class NextLineElement : DocumentElement
{
    public override string Render()
    {
        return "\n";
    }
}