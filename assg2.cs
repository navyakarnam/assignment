using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(ExchangeFirstAndLast("abed"));  // "deba"
        Console.WriteLine(ExchangeFirstAndLast("a"));     // "a"
        Console.WriteLine(ExchangeFirstAndLast("xy"));    // "yx"
    }

    static string ExchangeFirstAndLast(string str)
    {
        if (str.Length <= 1) // If the string is a single character or empty
        {
            return str;
        }

        return str[str.Length - 1] + str.Substring(1, str.Length - 2) + str[0];
    }
}