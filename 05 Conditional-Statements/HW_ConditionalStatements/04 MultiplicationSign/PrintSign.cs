/*
Problem 4.	Multiplication Sign
Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators. Examples:
a	    b	    c	    result
5	    2	    2	    +
-2	    -2	    1	    +
-2	    4	    3	    -
0	    -2.5	4	    0
-1	    -0.5	-5.1	-
*/

using System;
class PrintSign
{

    static void Main(string[] args)
    {
        double a = -1;
        double b = 0.5;
        double c = -3;
        string positiveSign = "+";
        string negativeSign = "-";
        string zero = "0";
        if ((a != 0) && (b != 0) && (c != 0))
        {
            if ( a > 0)
            {
                if ( b > 0)
                {
                    if ( c > 0 ) //+a; +b; +c
                    {
                        Console.WriteLine(positiveSign);
                    }
                    else // +a; +b; -c
                    {
                        Console.WriteLine(negativeSign);
                    }
                }
                else // +a ; -b; 
                {
                    if ( c > 0)
                    {
                        Console.WriteLine(negativeSign);
                    }
                    else
                    {
                        Console.WriteLine(positiveSign);
                    }
                }
            }
            else // (a < 0) -> true
            {
                if ( b > 0)
                {
                    if ( c > 0)
                    {
                        Console.WriteLine(negativeSign);
                    }
                    else // -a; +b; -c
                    {
                        Console.WriteLine(positiveSign);
                    }
                }
                else // -a; -b;
                {
                    if ( c > 0)
                    {
                        Console.WriteLine(positiveSign);
                    }
                    else // -a; -b; -c
                    {
                        Console.WriteLine(negativeSign);
                    }
                }

            }
         
           
        }
        else
        {
            Console.WriteLine(zero);
        }
    }
}