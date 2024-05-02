using System;
using System.Collections.Generic;
using System.IO;
class Program
{

    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator thePromptGenerator = new PromptGenerator();
        string filename = "myfile.txt";
        //Load previously saved data
        while (true)
        {
            // menu options
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            // user choice
            Console.WriteLine("Welcome to the Journal Program!");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            // based on choice, perform function
            if (choice == "1")
            {
                // Write a new entry
                Entry newEntry = new Entry();
                Console.Write("Enter the date: ");
                newEntry._dates = Console.ReadLine();
                string Prompt = thePromptGenerator.GetRandomPrompt();
                Console.Write(Prompt);
                newEntry._promptText = Prompt;
                newEntry._entryText = Console.ReadLine();
                Console.Write("From 1-5 Rate Today, 5 Being Excellent, 1 Not so Much:");
                newEntry._ratingText = Console.ReadLine();
                theJournal.AddEntry(newEntry);
            }

            else if (choice == "2")
            {
                // Display the journal
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                // Save the journal to a file
                Console.Write("Enter Filename to save: ");
                filename = Console.ReadLine();
                theJournal.SavetoFile(filename);
            }
            else if (choice == "4")
            {
                // Load the journal from a file
                Console.Write("Enter Filename to load: ");
                filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                // Exit the program
                Console.WriteLine("Exiting the program...");
                break; // Exit the loop and end the program
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            }
        }
    }
}
