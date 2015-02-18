/*
Problem 5.	Formatting Numbers
Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned. Examples: // {0,10:X} | {1,10: } | {2: }
a	    b	         C	        Result
254	    11.6	    0.5	        |FE        |0011111110|     11.60|0.500     |
499	    -0.5559 	10000	    |1F3       |0111110011|     -0.56|10000     |
0	    3	        -0.1234	    |0         |0000000000|         3|-0.123    |
*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter integer number: ");
        int myInt = int.Parse(Console.ReadLine());
        string myIntegerToBinary = Convert.ToString(myInt, 2);
        Console.WriteLine("Enter floating-point number: ");
        float myFirstFloat = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter floating-point number: ");
        float mySecondFloat = float.Parse(Console.ReadLine());

        Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", 
            myInt, myIntegerToBinary.PadLeft(10,'0'), myFirstFloat, mySecondFloat);
    }
}