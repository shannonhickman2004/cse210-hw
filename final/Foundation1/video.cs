using System.Collections.Generic;

public class Video
{
    private string title;
    private string author;
    private int length;
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = new List<Comment>();
    }
    public string GetTitle() => title;
    public string GetAuthor() => author;
    public int GetLength() => length;
    public int GetNumberofComments() => comments.Count;

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public List<Comment> GetComments() => comments;
}