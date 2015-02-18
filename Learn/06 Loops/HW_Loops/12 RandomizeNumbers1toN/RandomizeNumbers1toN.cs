/*
Problem 12.	* Randomize the Numbers 1…N
Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. Examples:
n	randomized numbers 1…n
3	2 1 3
10	3 4 8 2 6 7 9 1 10 5 
Note that the above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.
*/

using System;
using System.Linq;
class RandomizeNumbers1toN
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] myArray = new int[n];

        //intialize array
        for (int i = 1; i <= myArray.Length; i++)
        {
            myArray[i-1] = i;
        }

        //shuffle array using "Fisher-Yates Shuffle"
        Random randomGenerator = new Random();
        for (int j = myArray.Length; j > 1; j--)
        {
            int indexShuffle = randomGenerator.Next(j);
            var tmp = myArray[indexShuffle];
            myArray[indexShuffle] = myArray[j - 1];
            myArray[j - 1] = tmp;
        }

        //print new array
        foreach (var item in myArray)
        {
            Console.Write("{0} ",item);   
        }

        Console.WriteLine();
    }

}