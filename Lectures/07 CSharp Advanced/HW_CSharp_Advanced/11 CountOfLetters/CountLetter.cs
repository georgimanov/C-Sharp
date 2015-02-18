/*
Problem 11.	Count of Letters
Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The letters should be listed in alphabetical order. Use the input and output format from the examples below. Examples:

Input	                                    Output
 * 
b b a a b	                                a -> 2
                                            b -> 3
 * 
h d h a a a s d f d a d j d s h a a	        a -> 6
                                            d -> 5
                                            f -> 1
                                            h -> 3
                                            j -> 1
                                            s -> 2
*/

using System;
using System.Linq;

class CountLetter
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        char[] uniqueChars = input.Distinct().ToArray();
        char[] arr = input.ToArray();

        Array.Sort(uniqueChars); //sorting also can be done with 2 for loops
        int counter = 0;
        for (int i = 1; i < uniqueChars.Length; i++) //start from 1 because 0 is ' ';
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (uniqueChars[i] == arr[j])
                {
                    counter++;
                }
            }
            Console.WriteLine("{0} -> {1}", uniqueChars[i], counter);
            counter = 0;
        }
    }
}
