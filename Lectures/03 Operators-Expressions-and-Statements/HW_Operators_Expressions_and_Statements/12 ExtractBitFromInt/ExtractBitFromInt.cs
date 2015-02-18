/*
Problem 12.	Extract Bit from Integer
Write an expression that extracts from given integer n the value of given bit at index p. Examples:
n	    binary representation	p	bit @ p
5	    00000000 00000101	    2	1
0	    00000000 00000000	    9	0
15	    00000000 00001111	    1	1
5343	00010100 11011111	    7	1
62241	11110011 00100001	    11	0
*/

using System;
class ExtractBitFromInt
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Input position: ");
        int position = int.Parse(Console.ReadLine());

        int nRightP = number >> position;
        int bit = nRightP & 1;
        Console.WriteLine("Int number {0}\nPostion {1}\nBit is {2}", number, position, bit);
    }
}