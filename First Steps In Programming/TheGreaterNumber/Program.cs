using System;

class TheGreaterNumber
{
    static void Main()
    {
        Console.Write(" ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write(" ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("Greater number: " + num1);
        }
        else if (num1 < num2)
        {
            Console.WriteLine("Greater number: " + num2);
        }
        else
        {
            Console.WriteLine("The two numbers are equal.");
        }
    }
}
