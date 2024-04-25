using System;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber;
        // This is the way the example did it
//        int userNumber = -1;
 //       while (userNumber != 0)
 //       {
  //          Console.Write("Enter a number (0 to quit): ");
 //           
  //          string userResponse = Console.ReadLine();
   //         userNumber = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
  //          if (userNumber != 0)
   //         {
   //             numbers.Add(userNumber);
  //          }

        do
        {
            Console.Write("Enter a number (0 to quit: )");

            string userentry = Console.ReadLine();
            userNumber = int.Parse(userentry);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        while (userNumber != 0);

        //Compute the sum
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //Compute the average

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        //Find the max

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is {max}");

        }
        
    
}