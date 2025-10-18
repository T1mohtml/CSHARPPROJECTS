using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Write a line
            Console.WriteLine("=== Simple Addition Calculator ===");

            // Get first number
            Console.Write("Enter the first number:  ");
            string input1 = Console.ReadLine();
            double num1 = Convert.ToDouble(input1);

            // Get second number
            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            double num2 = Convert.ToDouble(input2);

            // Calculate and display result
            double result = num1 + num2;
            Console.WriteLine($"Result: {num1} + {num2} = {result}");

            // Prompt user
            Console.WriteLine("Press Enter  to continue, or any other key to quit...");
            var key = Console.ReadKey(true); // true hides the key from console

            if (key.Key != ConsoleKey.Enter)
            {
                break; // Exit loop if not Enter
            }

            Console.Clear(); // Clear screen for next calculation
        }
    }
}
