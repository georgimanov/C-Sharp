
/*
Problem 15.	Extract URLs from Text
Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
•	http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
•	www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com
Examples:
Input	
The site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information.	http://nakov.com

 * 
 * Output
 * 
 www.nakov.com
http://blog.nakov.com*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractURL
{

    static List<string> GetLinks(string text)
    {
        List<string> links = new List<string>();

        Regex urls = new Regex(@"((https?|ftp|file)\://|www.)[A-Za-z0-9\.\-]+(/[A-Za-z0-9\?\&\=;\+!'\(\)\*\-\._~%]*)*",
                               RegexOptions.IgnoreCase);

        MatchCollection matches = urls.Matches(text);
        foreach (Match match in matches)
        {
            links.Add(match.Value);
        }

        return links;
    }
    static void Main()
    {
        string someText = Console.ReadLine();

        List<string> urls = GetLinks(someText).Distinct().ToList(); //Again use Distinct if you dont want repeated elements

        Console.WriteLine();
        Console.WriteLine("The url links are:");
        Console.WriteLine();

        foreach (var item in urls)
        {
            Console.WriteLine(item);
        }
    }
}