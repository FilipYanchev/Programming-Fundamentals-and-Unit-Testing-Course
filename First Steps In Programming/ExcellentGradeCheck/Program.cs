using System;

class ExcellentGradeCheck
{
    static void Main()
    {
        // Initialize a double variable (grade) and assign a value from the input from the console
        Console.Write(" ");
        double grade = double.Parse(Console.ReadLine());

        // Check if the value meets the condition and if so, print the desired result on the console
        if (grade >= 5.50)
        {
            Console.WriteLine("Excellent!");
        }
    }
}
