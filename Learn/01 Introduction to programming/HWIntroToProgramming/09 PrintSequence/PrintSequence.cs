//09. Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;
class PrintSequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i < 12; i++)
        {
            Console.Write("{0} --> ", (i-1));
            if (i % 2 == 0)
            {
                ;
                Console.WriteLine("{0}",i);
            }
            else
            {
                Console.WriteLine("{0}",(-i));
            }
        }
    }
}

