/*Problem 12. Subtracting polynomials

    Extend the previous program to support also subtraction and multiplication of polynomials.
*/

using System;

class SubtractingPolynomials
{
    static void Main(string[] args)
    {
        decimal[] firstPolynom = { 5, -1 };
        decimal[] secondPolynom = { 10, -5, 6 };
        decimal[] result = new decimal[Math.Max(firstPolynom.Length, secondPolynom.Length)];

        Console.Write("First polynom:   ");
        PrintPolynom(firstPolynom);
        Console.Write("Second polynom:   ");
        PrintPolynom(secondPolynom);
        result = SubofPolynom(firstPolynom, secondPolynom, result);
        Console.Write("Subtraction       ");
        PrintPolynom(result);
        Console.WriteLine(new string('-', 40));
        decimal[] multiply = new decimal[(firstPolynom.Length + secondPolynom.Length)];
        result = MultiplicationofPolynom(firstPolynom, secondPolynom, multiply);
        Console.Write("Multiplication:   ");
        PrintPolynom(result);
    }
    static void PrintPolynom(decimal[] polynom)
    {
        for (int i = polynom.Length - 1; i >= 0; i--)
        {
            if (polynom[i] != 0 && i != 0)
            {
                if (polynom[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} + ", i, polynom[i]);
                }
                else
                {
                    Console.Write("{1}x^{0}  ", i, polynom[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polynom[i]);
            }
        }
        Console.WriteLine();
    }

    static decimal[] SubofPolynom(decimal[] first, decimal[] second, decimal[] result)
    {
        if (first.Length > second.Length)
        {
            return SubofPolynom(second, first, result);
        }
        int i = 0;

        for (; i < first.Length; i++)
        {
            result[i] = first[i] - second[i];
        }

        for (; i < second.Length; i++)
        {
            result[i] = second[i];
        }
        return result;
    }

    static decimal[] MultiplicationofPolynom(decimal[] first, decimal[] second, decimal[] result)
    {

        for (int i = 0; i < second.Length; i++)
        {
            result[i] = 0;
        }

        for (int i = 0; i < first.Length; i++)
        {
            for (int j = 0; j < second.Length; j++)
            {
                int position = i + j;
                result[position] += (first[i] * second[j]);
            }
        }
        return result;
    }
}