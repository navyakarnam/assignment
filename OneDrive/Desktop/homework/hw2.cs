using System;
using System.Linq;

namespace Assignment3Solving
{
    class WordReverse
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the word: ");
            string str = Console.ReadLine();
            string revStr = new string(str.Reverse().ToArray());
            Console.WriteLine($"Reversed word is: {revStr}");
            Console.ReadKey();
        }
    }
}