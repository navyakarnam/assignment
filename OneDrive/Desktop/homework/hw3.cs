using System;

namespace Assignment3Solving
{
    class DisplayWordLength
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the word to find its length: ");
            string str = Console.ReadLine();
            Console.WriteLine($"Length of the word is: {str.Length}");
            Console.ReadKey();
        }
    }
}