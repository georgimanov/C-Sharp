/*
Problem 2.	Bonus Score
Write a program that applies bonus score to given score in the range [1…9] by the following rules:
•	If the score is between 1 and 3, the program multiplies it by 10.
•	If the score is between 4 and 6, the program multiplies it by 100.
•	If the score is between 7 and 9, the program multiplies it by 1000.
•	If the score is 0 or more than 9, the program prints “invalid score”.
Examples:
score	result
2	    20
4	    400
9	    9000
-1	    invalid score
10	    invalid score
*/

using System;
class BonusScore
{
    static void Main()
    {
        int a = 9;
        string wrongInput = "invalid score";
        switch (a)
        {
            case 1: Console.WriteLine("{0}", a*10); break;
            case 2: Console.WriteLine("{0}", a*10); break;
            case 3: Console.WriteLine("{0}", a*10); break;
            case 4: Console.WriteLine("{0}", a*100); break;
            case 5: Console.WriteLine("{0}", a*100); break;
            case 6: Console.WriteLine("{0}", a*100); break;
            case 7: Console.WriteLine("{0}", a*1000); break;
            case 8: Console.WriteLine("{0}", a*1000); break;
            case 9: Console.WriteLine("{0}", a*1000); break;
            default: Console.WriteLine("{0}", wrongInput); break;
        }
    }
}