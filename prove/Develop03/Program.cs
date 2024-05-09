using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
 
        string fileName = "..\\..\\..\\randomscripture.csv";
        string directory = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(directory, fileName);

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');

                    Reference reference = new Reference(parts[0]);
                    string text = parts[1];

                    scriptures.Add(new Scripture(reference, text));
                }
            }

            Random random = new Random();
            Scripture randomScripture = scriptures[random.Next(scriptures.Count)];

            while (!randomScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(randomScripture.GetDisplayText());
                Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                else
                    randomScripture.HideRandomWords(3);
            }
        }
        catch (Exception ex)
        
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        
    }
}
