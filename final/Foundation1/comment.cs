public class Comment
{
    private string name;
    private string text;

    // Constructor
    public Comment(string name, string text)
    {
        this.name = name;
        this.text = text;
    }

    public string GetName() => name;
    public string GetText() => text;
}
