/*
 *Problem 16.* Print Long Sequence
 *
 *Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
 *You might need to learn how to use loops in C# (search in Internet).
 *using System;
 */
using System;

class LongSequence
{
    static void Main()
    {
        int start = 2;
        for (int i = 1; i <= 1000; i++)
        {
            Console.WriteLine(start * (Math.Pow(-1, i + 1)));
            start += 1;
        }
    }
}
