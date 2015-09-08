using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Please, enter 2 numbers one by one, each followed by \"Enter\", then press \"Enter\" to get the result: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(a, b)); //Returns the larger of two numbers, compares them.
    }
}

