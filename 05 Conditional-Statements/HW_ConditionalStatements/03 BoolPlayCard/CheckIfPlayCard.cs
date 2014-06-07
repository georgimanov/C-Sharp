/*
Problem 3.	Check for a Play Card
Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
character	Valid card sign?
5	yes
1	no
Q	yes
q	no
P	no
10	yes
500	no
*/

using System;
class CheckIfPlayCard
{
    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();
        string validCard = "yes";
        string invalidCard = "no";

        switch (inputString)
        {
            case "2": Console.WriteLine("{0}", validCard); break;
            case "3": Console.WriteLine("{0}", validCard); break;
            case "4": Console.WriteLine("{0}", validCard); break;
            case "5": Console.WriteLine("{0}", validCard); break;
            case "6": Console.WriteLine("{0}", validCard); break;
            case "7": Console.WriteLine("{0}", validCard); break;
            case "8": Console.WriteLine("{0}", validCard); break;
            case "9": Console.WriteLine("{0}", validCard); break;
            case "10": Console.WriteLine("{0}", validCard); break;
            case "J": Console.WriteLine("{0}", validCard); break; //case sensitive
            case "Q": Console.WriteLine("{0}", validCard); break; //case sensitive
            case "K": Console.WriteLine("{0}", validCard); break; //case sensitive
            case "A": Console.WriteLine("{0}", validCard); break; //case sensitive
            default: Console.WriteLine("{0}", invalidCard);
                break;
        }
    }
}