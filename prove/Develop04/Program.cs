using System;

class Program
{
    static void Main(string[] args)
    {
        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Journaling Activity");
            Console.WriteLine("5. Quit");

            Console.WriteLine("Which activity would you like to do today?");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Starting Breathing Activity...");
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Starting Listing Activity...");
                ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.Run();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Starting Reflecting Activity...");
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectingActivity.Run();
            }

             else if (choice == "4")
            {
                Console.WriteLine("Starting Reflecting Activity...");
                JournalingActivity journalingActivity = new JournalingActivity("Journal Activity", "This activity will allow you to just place your thoughts and process.");
                journalingActivity.Run();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Exiting the program...");
                exitProgram = true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
            }

            Console.WriteLine();
        }
        Console.WriteLine("Done.");
    
    }


}
