/*
Problem 13.	Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. Examples:
n	    binary representation of n	p	bit @ p == 1
5	    00000000 00000101	        2	true
0	    00000000 00000000	        9	false
15	    00000000 00001111	        1	true
5343	00010100 11011111	        7	true
62241	11110011 00100001	        11	false
*/

using System;
class CheckBitAtPosition
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Input position: ");
        int position = int.Parse(Console.ReadLine());

        int nRightP = number >> position;
        int bit = nRightP & 1;
        bool isOne = bit == 1;
        Console.WriteLine("Is bit @ p {0} == 1 ? \n{1}", position, isOne);
    }
}