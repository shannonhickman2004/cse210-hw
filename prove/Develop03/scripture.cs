using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        //this is added when trying to do random scriptures
        // this should be the scripture reference
        _reference = reference;
        _words = text.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(word => new Word(word))
             .ToList();
    }
    public void HideRandomWords(int numbertoHide)
    {
        if (numbertoHide <= 0)
            return;

        Random random = new Random();
        for (int i = 0; i < numbertoHide; i++)
        {
            int randomIndex = random.Next(_words.Count);
            _words[randomIndex].Hide();
        }
    }


    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.IsHidden ? "___" : word.GetDisplayText);
        }
        return string.Join(" ", displayWords);
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}