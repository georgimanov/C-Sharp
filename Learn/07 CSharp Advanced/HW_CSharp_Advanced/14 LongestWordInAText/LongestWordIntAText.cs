/*
Problem 14.	Longest Word in a Text
Write a program to find the longest word in a text. Examples:
Input	Output
Welcome to the Software University.	University
The C# Basics course is awesome start in programming with C# and Visual Studio.	programming
*/

using System;

class LongestWordInText
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();

        string[] arr = text.Split(new char[] { ' ', '.', ',', '!', '"', }, StringSplitOptions.RemoveEmptyEntries);

        string temp = "";

        for (int write = 0; write < arr.Length; write++)
        {
            for (int sort = 0; sort < arr.Length - 1; sort++)
            {
                if (arr[sort].Length > arr[sort + 1].Length)
                {
                    temp = arr[sort + 1];
                    arr[sort + 1] = arr[sort];
                    arr[sort] = temp;
                }
            }
        }
        Console.WriteLine(arr[arr.Length - 1]);
    }
}