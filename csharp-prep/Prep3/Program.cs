using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your magic number guess");
        int magicGuess = int.Parse(Console.ReadLine());

         // For Part 3, where we use a random number, this I added in for later to look at, I found it from the sample code.
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
    

        int guess = -1;

        while (guess != magicGuess)
    {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicGuess > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicGuess < guess)
            {   
                Console.WriteLine("Lower");
            }
            else
            {   
                Console.WriteLine("You guessed it!");
            }
        }

    }
    
}