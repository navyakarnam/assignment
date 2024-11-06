using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(RemoveChar("Python", 1)); 
        Console.WriteLine(RemoveChar("Python", 0)); 
        Console.WriteLine(RemoveChar("Python", 4)); 
    }

    static string RemoveChar(string str, int position)
    {
        if (position < 0 || position >= str.Length) // Ensure valid position
        {
            return str; // Return the original string if position is invalid
        }
        
        return str.Substring(0, position) + str.Substring(position + 1);
    }
}