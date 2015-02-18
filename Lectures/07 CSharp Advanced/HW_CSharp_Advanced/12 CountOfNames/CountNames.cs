/*
Problem 12.	Count of Names
Write a program that reads a list of names and prints for each name how many times it appears in the list. The names should be listed in alphabetical order. Use the input and output format from the examples below. Examples:
Input	
 * Output
 * 
Peter Steve Nakov Steve Alex Nakov	
 * Alex -> 1
 * Nakov -> 2
 * Peter -> 1
 * Steve -> 2
 * 
Nakov Nakov Nakov SoftUni Nakov
 * SoftUni -> 1
 * Nakov -> 5
*/


using System;
using System.Collections.Generic;
using System.Linq;

class CountLetter
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] arr = input.Split(' ');

        Array.Sort(arr); //sorting also can be done with 2 for loops

        List<string> namesToPrint = new List<string>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (!namesToPrint.Contains(arr[i]))
            {
                namesToPrint.Add(arr[i]);
            }
            
        }

        int counter = 0;
        for (int i = 0; i < namesToPrint.Count; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                    if (namesToPrint[i] == arr[j])
                    {
                        counter++;
                    }
            }
                Console.WriteLine("{0} -> {1}", namesToPrint[i], counter);
                counter = 0;
        }
    }
}