/*
 *Problem 9. Print a Sequence
 *
 *Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
 */
using System;

class PrintNumberSequence
{
    static void Main()
    {
        int start = 2;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(start*(Math.Pow(-1, i+1)));
            start += 1;
        }
    }
}
