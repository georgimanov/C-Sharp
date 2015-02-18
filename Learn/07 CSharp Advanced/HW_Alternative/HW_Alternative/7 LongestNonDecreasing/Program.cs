/*
Problem 8.	* Longest Non-Decreasing Subsequence
Write a program that reads a sequence of integers and finds in it the longest non-decreasing subsequence. In other words, you should remove a minimal number of numbers from the starting sequence, so that the resulting sequence is non-decreasing. In case of several longest non-decreasing sequences, print the leftmost of them. The input and output should consist of a single line, holding integer numbers separated by a space. Examples:
Input	                                    Output
1	                                        1
7 3 5 8 -1 6 7	                            3 5 6 7
1 1 1 2 2 2	                                1 1 1
1 1 1 3 3 3 2 2 2 2	                        2 2 2 2
11 12 13 3 14 4 15 5 6 7 8 7 16 9 8	3       4 5 6 7 8 9
*/


using System;
using System.Collections.Generic;

class LongestNonDecreasingSubsequence
{

    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' '.ToString().ToCharArray(),
                                        StringSplitOptions.RemoveEmptyEntries);


        int[] nums = new int[numbers.Length];
        int max = 0, lastIndex = 0, count = 0, constMax = 0;

        List<int> maxCount = new List<int>();
        List<int> constMaxCount = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(numbers[i]);
        }

        for (int i = 0; i < nums.Length - 1; i++)
        {
            max = 0;
            maxCount = new List<int>();
            maxCount.Add(nums[i]);
            count = 0;
            lastIndex = i;

            for (int j = i; j < nums.Length - 1; j++)
            {
                if (nums[lastIndex] <= nums[lastIndex + 1])
                {
                    max++;
                    maxCount.Add(nums[lastIndex + 1]);
                    count++;
                    lastIndex++;
                }

                else if (count > 0)
                {
                    if (maxCount[count] > nums[j] && maxCount[count - 1] < nums[j])
                    {
                        maxCount[count] = nums[j];
                        lastIndex = j;
                    }
                }

            }

            if (max > constMax)
            {
                constMax = max;
                constMaxCount = maxCount;
            }

        }

        if (nums[nums.Length - 1] > nums[nums.Length - 2])
        {
            constMaxCount.Add(nums[nums.Length - 1]);
        }

        foreach (var number in constMaxCount)
        {
            Console.Write("{0} ", number);
        }
    }
}