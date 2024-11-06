using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        Console.Write("Enter the letter to count: ");
        char letter = Console.ReadLine()[0];  // Get the first character input

        int count = 0;
        
        foreach (char ch in inputString)
        {
            if (ch == letter)
            {
                count++;
            }
        }

        Console.WriteLine($"The letter '{letter}' appears {count} times in the string.");
    }
}