using System;

class AnimalTypes
{
    static void Main()
    {
        Console.Write(" ");
        string animal = Console.ReadLine().ToLower(); // Convert to lower case to make the comparison case-insensitive

        switch (animal)
        {
            case "dog":
                Console.WriteLine("mammal");
                break;
            case "crocodile":
            case "tortoise":
            case "snake":
                Console.WriteLine("reptile");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}
