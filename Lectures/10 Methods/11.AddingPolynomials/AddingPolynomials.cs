/*
 * Problem 11. Adding polynomials

    Write a method that adds two polynomials.
    Represent them as arrays of their coefficients.

Example:

x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
 * 
 */

using System;
class AddingPolynomials
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
        result = SumofPolynom(firstPolynom, secondPolynom, result);
        Console.Write("Sum               ");
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

    static decimal[] SumofPolynom(decimal[] first, decimal[] second, decimal[] result)
    {
        if (first.Length > second.Length)
        {
            return SumofPolynom(second, first, result);
        }

        int i = 0;

        for (; i < first.Length; i++)
        {
            result[i] = first[i] + second[i];
        }

        for (; i < second.Length; i++)
        {
            result[i] = second[i];
        }

        return result;
    }
}