/*
Problem 10.	Join Lists
Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line. Examples:
Input	                            Output
 * 
20 40 10 10 30 80
25 20 40 30 10	                    10 20 25 30 40 80
 * 
5 4 3 2 1
6 3 2	                            1 2 3 4 5 6
 * 
1
1	                                1
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class JoinLists
{
    public static void Main()
    {
        Console.Write("Enter first line :");
        string firstLine = Console.ReadLine();

        Console.WriteLine("Enter second line :");
        string secondLine = Console.ReadLine();

        string[] firstList = firstLine.Split(' ');

        List<int> first = new List<int> { };

        foreach (string word in firstList)
        {
            first.Add(int.Parse(word));
        }

        string[] secondList = secondLine.Split(' ');

        List<int> second = new List<int> { };

        foreach (string word in secondList)
        {
            second.Add(int.Parse(word));
        }

        List<int> newList = new List<int> { };

        foreach (int number in first)
        {
            if (!newList.Contains(number))
            {
                newList.Add(number);
            }
        }

        foreach (int number in second)
        {
            if (!newList.Contains(number))
            {
                newList.Add(number);
            }
        }

        newList.Sort();

        Console.Write(new string('-', 30));

        foreach (int number in newList)
        {
            Console.Write(number + " ");
        }
    }
}

