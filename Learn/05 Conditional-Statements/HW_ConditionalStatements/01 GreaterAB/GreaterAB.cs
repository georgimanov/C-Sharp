/*
Problem 1.	Exchange If Greater
Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space. Examples:
a	b	result
5	2	2 5
3	4	3 4
5.5	4.5	5.5 4.5
*/

using System;
class GreaterAB
{
    static void Main()
    {
        float a = 5.5f;
        float b = 4.5f;
        float c;
        if ( a > b)
        {
            c = a;
            a = b;
            b = c;

            Console.WriteLine("{0} {1}", a, b);
        }
        else 
        {
            
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}