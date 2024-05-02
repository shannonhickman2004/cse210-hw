using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SavetoFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._dates}");
                outputFile.WriteLine($"Prompt: {entry._promptText}");
                outputFile.WriteLine($"Entry: {entry._entryText}");
                outputFile.WriteLine($"Rating: {entry._ratingText}");
                outputFile.WriteLine(); // Add an empty line between entries for readability
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear(); // Clear existing entries before loading from file

        using (StreamReader reader = new StreamReader(filename))
        {
            string dateText;
            string promptText;
            string entryText;
            string ratingText;

            while ((dateText = reader.ReadLine()) != null)
            {
                promptText = reader.ReadLine();
                entryText = reader.ReadLine();
                ratingText = reader.ReadLine();
                reader.ReadLine();  //For empty line in file

                Entry entry = new Entry
                {
                    _dates = TextAfterColon(dateText),
                    _promptText = TextAfterColon(promptText),
                    _entryText = TextAfterColon(entryText),
                    _ratingText = TextAfterColon(ratingText)
                };

                _entries.Add(entry);
            }
        }
    }

    public string TextAfterColon(string line)
    {
        string[] parts = line.Split(":");
        return parts[1].TrimStart();

    }
}