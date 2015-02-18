/*
Problem 16.	* Counting a Word in a Text
Write a program that counts how many times a given word occurs in given text. The first line in the input holds the word. The second line of the input holds the text. The output should be a single integer number – the number of word occurrences. Matching should be case-insensitive. Note that not all matching substrings are words and should be counted. A word is a sequence of letters separated by punctuation or start / end of text. Examples:
Input	
hi
Hidden networks say “Hi” only to Hitachi devices. Hi, said Matuhi. HI!	
 * 
 * Output
 * 3

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountingWordsText
{
    static int CompareWords(string inputWord, string inputText)
    {
        string[] allWords = inputText.Split(
            new char[] { ' ', '.', ',', '"', '@', '!', '?', '/', '\\', ':', ';', '(', ')' },
            StringSplitOptions.None);

        int counter = 0;

        for (int i = 0; i < allWords.Length; i++)
        {
            //string.Equals give better options to compare strings (like ignore casing)
            if (string.Equals(allWords[i], inputWord, StringComparison.OrdinalIgnoreCase))
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        string keyWord = Console.ReadLine();
        string someText = Console.ReadLine();

        int result = CompareWords(keyWord, someText);
        Console.WriteLine(result);
    }
}