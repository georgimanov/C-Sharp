/*
Problem 6.	Longest Area in Array
Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them. Examples:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestArea
{
    class LongestArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter n of n elements: ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Element {0} = ", i);
                array[i] = Console.ReadLine();
            }
            int lenghtCount = 0;
            int counter = 0;
            int temp = 0;
            int count = 0;
            int len = 0;
            List<string> equal = new List<string>();

            for (int k = 0; k < array.Length; k++)
            {
                for (int j = 1 + k; j < array.Length; j++)
                {
                    if (array[k] == array[j])
                    {
                        if (array.Length == equal.Count + 1 && counter == 0)
                        {
                            temp++;
                            equal.Add(array[k]);
                            Console.WriteLine(temp);
                            foreach (var item in equal)
                            {
                                Console.WriteLine(item);
                            }
                            return;
                        }
                        else if (temp == k && j == array.Length - 1)
                        {
                            equal.RemoveRange(0, count + 1);
                            counter = equal.Count;
                            Console.WriteLine(temp);
                            foreach (var item in equal)
                            {
                                Console.WriteLine(item);
                            }
                            return;
                        }
                        equal.Add(array[k]);
                        temp++;
                        lenghtCount++;
                        counter++;
                        len = count;
                        count = counter;

                    }
                    else if (temp > 0)
                    {
                        equal.Add(array[k]);
                        temp = 0;
                        k = j;
                        continue;
                    }

                }
                counter = 0;
            }
            if (lenghtCount == 0)
            {
                counter = 1;
                Console.WriteLine(counter);
                var lenghts = from element in array
                              orderby element.Length
                              select element;
                Console.WriteLine(lenghts.Last());
                return;
            }
            else if (temp == equal.Count)
            {
                equal.Add(array[temp]);
                counter = equal.Count;
            }
            else if (len > temp)
            {
                equal.Reverse();
                equal.RemoveRange(0, temp);
                counter = equal.Count;
            }
            else if (temp > len)
            {
                equal.RemoveRange(0, len);
                counter = equal.Count;
            }
            else if (len == temp)
            {
                equal.Reverse();
                equal.RemoveRange(0, temp);
                counter = equal.Count;
            }
            Console.WriteLine(counter);
            foreach (var item in equal)
            {
                Console.WriteLine(item);
            }
        }
    }
}