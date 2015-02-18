//16 Print Long Sequence
// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … You might need to learn how to use loops (search in Internet).

using System;
class PrintLongSequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i < 1002; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Row {0} : {1}", i - 1, i);
            }
            else
            {
                Console.WriteLine("Row {0} : {1}", i - 1, -i);
            }
        }
    }
}