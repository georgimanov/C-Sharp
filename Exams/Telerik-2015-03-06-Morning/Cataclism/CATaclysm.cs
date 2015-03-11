using System;
using System.Collections.Generic;
using System.Linq.Expressions;
class CATaclysm
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char[] delimiters = new char[] { '(', ')', '{', '}', ';', '=', '+', '-' };
        List<string> methods = new List<string>();
        List<string> loops = new List<string>();
        List<string> conditionalStatements = new List<string>();

        bool isCondition = false; // if else
        bool isLoop = false; // for; while; foreach
        bool isMethod = false; // 

        string[] sourceCoode = new string[n];

        for (int i = 0; i < n; i++)
        {
            sourceCoode[i] = Console.ReadLine();
            
        }


      


        Console.WriteLine("Methods -> {0}", string.Join(", ", methods));
        Console.WriteLine("Loops  -> {0}", string.Join(", ", loops));
        Console.WriteLine("Conditional Statements -> {0}", string.Join(", ", conditionalStatements));
    }

   
}