using System;

public class Reference
{
    private string _book;
    private int _chapter;

    private int _verse;

    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
      
    }

    public Reference(string referenceText)
    {
        var parts = referenceText.Split(" ");
        _book = parts[0];
        var chapterVerseParts = parts[1].Split(":");

        var chapterText = chapterVerseParts[0];
        var versusText = chapterVerseParts[1];

        _chapter = int.Parse(chapterText);

        var verseParts =versusText.Split("-");

        _verse = int.Parse(verseParts[0]);
        if(verseParts.Length > 1)
        {
            _endVerse = int.Parse(verseParts[1]);
        }
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;    
    }

    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter};{_verse}";
        }
        else
        {
            return $"{_book} {_chapter};{_verse}-{_endVerse}";
        }
    }

}
