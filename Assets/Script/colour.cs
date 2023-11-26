using System;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Regular message in white.");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Success message in green.");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Warning message in yellow.");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error message in red.");

        // Reset the console color to default
        Console.ResetColor();

        Console.WriteLine("Back to the default color.");

        Console.ReadLine(); // Pause to see the output
    }
}