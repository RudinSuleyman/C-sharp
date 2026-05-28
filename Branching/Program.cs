using System;

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user for package weight
        Console.WriteLine("Please enter the package weight:");
        int weight = Convert.ToInt32(Console.ReadLine());

        // Check if weight exceeds limit
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End program
        }

        // Prompt user for package width
        Console.WriteLine("Please enter the package width:");
        int width = Convert.ToInt32(Console.ReadLine());

        // Prompt user for package height
        Console.WriteLine("Please enter the package height:");
        int height = Convert.ToInt32(Console.ReadLine());

        // Prompt user for package length
        Console.WriteLine("Please enter the package length:");
        int length = Convert.ToInt32(Console.ReadLine());

        // Check if dimensions exceed limit
        int dimensionTotal = width + height + length;
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End program
        }

        // Calculate shipping quote
        int dimensionsProduct = width * height * length;
        int quote = (dimensionsProduct * weight) / 100;

        // Display shipping quote
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00");
        Console.WriteLine("Thank you!");
    }
}
