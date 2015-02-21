/*
 * Problem 13. Solve tasks

    Write a program that can solve these tasks:
        Reverses the digits of a number
        Calculates the average of a sequence of integers
        Solves a linear equation a * x + b = 0
    Create appropriate methods.
    Provide a simple text-based menu for the user to choose which task to solve.
    Validate the input data:
        The decimal number should be non-negative
        The sequence should not be empty
        a should not be equal to 0
*/

using System;

class SolveTasks
{
    static void Main()
    {
        Console.WriteLine("SELECT TASK TO SOLVE:");
        Console.Write("\u250c");
        Console.Write("----------------------------------------");
        Console.WriteLine("\u2510");
        Console.WriteLine("| 1. Reverse the digits of a number      |");
        Console.WriteLine("| 2. Calculate Average                   |");
        Console.WriteLine("| 3. Solve linear equation a * x + b = 0 |");
        Console.Write("\u2514");
        Console.Write("----------------------------------------");
        Console.WriteLine("\u2518");

        Console.Write("Choice: ");
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
                ReverseInput();
                break;
            case 2:
                InputAverage();
                break;
            case 3:
                EquationInput();
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }
    }

    static void EquationInput()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("a must not be equal to Zero!");
        }
        else
        {
            Console.WriteLine("Equation result is {0}", CalculateEquation(a, b));
        }
    }

    static double CalculateEquation(int a, int b)
    {
        return (double)-b / a;
    }

    static void InputAverage()
    {
        Console.Write("Enter size of sequence: ");
        int size = int.Parse(Console.ReadLine());

        if (size <= 0)
        {
            Console.WriteLine("The sequence must have at leaste 1 or more elements ");
            return;
        }

        int[] sequence = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("sequence[{0}] = ", i);
            sequence[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The average sequence is: {0}", CalculateAverage(sequence));
    }

    static double CalculateAverage(int[] sequence)
    {
        int sum = 0;

        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }

        return (double)sum / sequence.Length;
    }

    static void ReverseInput()
    {
        Console.Write("Enter number: ");
        string number = Console.ReadLine();

        if (decimal.Parse(number) > 0)
        {
            Console.WriteLine("The reversed number is " + Reverse(number));
        }
        else
        {
            Console.WriteLine("The number must be non-negative!");
        }
    }

    static decimal Reverse(string number)
    {
        char[] toBeReversed = number.ToCharArray();
        Array.Reverse(toBeReversed);
        string reversed = new string(toBeReversed);

        decimal reversedNumber = decimal.Parse(reversed);

        return reversedNumber;
    }
}