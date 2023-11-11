using System;

class InchesToCentimetersConverter
{
    static void Main()
    {
        Console.Write(" ");
        string input = Console.ReadLine();

        // Try to parse the input to a double, if it fails, it will ask again.
        if (double.TryParse(input, out double inches))
        {
            double centimeters = inches * 2.54;
            Console.WriteLine($" {centimeters}");
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}




