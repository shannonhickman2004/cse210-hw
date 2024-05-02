using System;

public class Entry
{

        public string _dates;
        public string _promptText;
        public string _entryText;

        public string _ratingText;

        public void Display()
        {
                Console.WriteLine($"Date: {_dates}");
                Console.WriteLine($"Prompt: {_promptText}");
                Console.WriteLine($"Entry: {_entryText}");
                Console.WriteLine($"Rating: {_ratingText}");
        }
}
