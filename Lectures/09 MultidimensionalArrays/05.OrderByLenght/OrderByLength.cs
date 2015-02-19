using System;
using System.Linq;
using System.Collections.Generic;   

class OrderByLength
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter words, separated by a comma: ");
        var words = Console.ReadLine()
            .Split(new char[] { ' ', '\t', ',', '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
            .OrderByDescending(x => x.Length)
            .ToList();

        
        words = words.Distinct().ToList();

        foreach (var word in words)
        {
            Console.WriteLine("{0,-6}{1}", word.Length, word);
        }
    }
}