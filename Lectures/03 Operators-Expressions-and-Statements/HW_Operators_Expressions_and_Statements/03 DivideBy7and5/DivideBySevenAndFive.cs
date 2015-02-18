/*Problem 3.	Divide by 7 and 5
Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. Examples:
n	Divided by 7 and 5?
3	false
0	false
5	false
7	false
*/

using System;
class DivideBySevenAndFive
{
    static void Main(string[] args)
    {
        int inputNumber = int.Parse(Console.ReadLine());

        if (inputNumber % 5 == 0 && inputNumber % 7 == 0 && inputNumber != 0)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
/*
        bool check = (inputNumber % 35 == 0) && (inputNumber != 0);
        Console.WriteLine(check);
*/