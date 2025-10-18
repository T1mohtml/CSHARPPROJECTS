using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("=== Simple Addition Calculator ===");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 + num2;
            Console.WriteLine($"Result: {num1} + {num2} = {result}");

            if (result == 67)
            {
                // Play WAV or MP3 using macOS 'afplay'
                Process.Start("afplay", "./67.wav"); // or "./67.mp3"
            }

            Console.WriteLine("Press Enter to continue, or any other key to quit...");
            var key = Console.ReadKey(true);
            if (key.Key != ConsoleKey.Enter) break;

            Console.Clear();
        }
    }
}
