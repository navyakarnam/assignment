using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(LargestNumber(1, 2, 3)); // 3
        Console.WriteLine(LargestNumber(1, 3, 2)); // 3
        Console.WriteLine(LargestNumber(1, 2, 2)); // 2
    }

    static int LargestNumber(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }
}