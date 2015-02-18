/*
Problem 9.	Remove Names
Write a program that takes as input two lists of names and removes from the first list all names given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line. Examples:
 * 
Input	                                            Output
 * 
Peter Alex Maria Todor Steve Diana Steve            Peter Alex Maria Diana
Todor Steve Nakov	                                
 * 
Hristo Hristo Nakov Nakov Petya                     Hristo Hristo Petya
Nakov Vanessa Maria	                                
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNames
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter first line:");
            string firstLine = Console.ReadLine();
            Console.Write("Enter second line:");
            string secondLine = Console.ReadLine();
            string[] firstList = firstLine.Split(' ');
            string[] secondList = secondLine.Split(' ');
            string[] newList = new string[firstList.Length];
            int i = 0;
            foreach (string word in firstList)
            {
                if (!secondList.Contains(word))
                {
                    newList.SetValue(word, i);
                    i++;
                }
            }
            Console.WriteLine(new String('-',30));
            foreach (string word in newList)
            {
                Console.Write(word + " ");
            }
        }
    }
}
