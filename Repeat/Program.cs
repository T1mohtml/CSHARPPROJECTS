using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter something (or type 'exit' to quit): ");
            string userInput = Console.ReadLine();

            if (userInput == null)
            {
                Console.WriteLine("Input was null. Exiting...");
                break;
            }

            if (userInput.Trim().ToLower() == "exit")
            {
                Console.WriteLine("Goodbye!");
                break; // Exit the loop
            }

            Console.WriteLine("You entered: " + userInput);
        }
    }
}
