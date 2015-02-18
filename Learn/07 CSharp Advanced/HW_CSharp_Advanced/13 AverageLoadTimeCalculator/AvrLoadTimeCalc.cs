/*
Problem 13.	Average Load Time Calculator
We have a report that holds dates, web site URLs and load times (in seconds) in the same format like in the examples below. Your tasks is to calculate the average load time for each URL. Print the URLs in the same order as they first appear in the input report. Print the output in the format given below. Use double floating-point precision. Examples:
*/


using System;
using System.Collections.Generic;
using System.Linq;

class AvrLoadTimeCalc
{
    static void Main(string[] args)
    {
        List<string> matrix = new List<string>();

        string line = " ";
        while (line != string.Empty)
        {
            line = Console.ReadLine();
            if(line != "")
            matrix.Add(line);
        }

        List<string> webSites = new List<string>();

        for (int i = 0; i < matrix.Count; i++)
        {
            String[] values = matrix[i].Split(' ');
            webSites.Add(values[2]);
        }

        List<string> printWebSite = new List<string>();

        for (int i = 0; i < webSites.Count; i++)
        {
            if (!printWebSite.Contains(webSites[i]))
            {
                printWebSite.Add(webSites[i]);
            }
        }

        double counter = 0;
        double time = 0;

        for (int i = 0; i < printWebSite.Count; i++)
        {
            for (int j = 0; j < webSites.Count; j++)
            {
                if (printWebSite[i] == webSites[j])
                {
                    String[] values = matrix[j].Split(new Char[] { ' ' });
                    time += double.Parse(values[3]);
                    counter++;
                }
            }
            Console.WriteLine("{0} -> {1}", printWebSite[i], time / counter);
            counter = 0;
            time = 0;
        }
    }
}