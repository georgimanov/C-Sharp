/*
Problem 15.	* Bits Exchange
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. Examples:
n	        binary representation of n	            binary result	                        result
1140867093	01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	    1107312677
255406592	00001111 00111001 00110010 00000000	    00001000 00111001 00110010 00111000	    137966136
4294901775	11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	    4194238527
5351	    00000000 00000000 00010100 11100111	    00000100 00000000 00010100 11000111	    67114183
2369124121	10001101 00110101 11110111 00011001	    10001011 00110101 11110111 00101001	    2335569705
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        long number = 4294901775;
        long bitA;
        long bitB;
        long bitC;

        string numberAsStringBefore = Convert.ToString(number, 2);
        Console.Write("{0}", number.ToString().PadRight(20));
        Console.WriteLine("{0}", numberAsStringBefore.PadLeft(32, '0'));

        for (int i = 3; i <= 5; i++)
        {
            
            bitA = GetBit(number, i);
            bitB = GetBit(number, (i + 21));
            bitC = bitA;
            bitA = bitB;
            bitB = bitC;
            number = SetBit(number, i, bitA);
            number = SetBit(number, (i + 21), bitB);
            
        }
        Console.Write("{0}", number.ToString().PadRight(20));
        string numberAsStringAfter = Convert.ToString(number, 2);
        Console.WriteLine(numberAsStringAfter.PadLeft(32, '0'));

    }

    public static long SetBit(long number, int position, long bitValue)
    {
        if (bitValue == 0)
        {
            int mask = ~(1 << position);
            long result = number & mask;
            return result;
        }
        else if (bitValue == 1)
        {
            long mask = 1 << position;
            long result = number | mask;
            return result;
        }
        else
        {
            return 0;
        }
    }

    public static long GetBit(long number, int position)
    {
        long nRightP = number >> position;
        long bit = nRightP & 1;

        return bit;
    }      
}