/*Problem 10. N Factorial

    Write a program to calculate n! for each n in the range [1..100].

Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
 */

using System;

class NFactorial
{
    static void Main()
    {
        byte[] factorial = { 1 };
        for (int i = 1; i <= 100; i++)
        {
            PrintNumber(factorial = Multiply(factorial, i));
        }
    }

    static void PrintNumber(byte[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i]);
        }

        Console.WriteLine();
    }

    static byte[] Add(byte[] a, byte[] b)
    {
        if (a.Length > b.Length)
        {
            return Add(b, a);
        }

        byte[] result = new byte[b.Length + 1];
        int i = 0, carry = 0;
        for (; i < a.Length; i++)
        {
            result[i] = (byte)(a[i] + b[i] + carry);
            carry = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < b.Length && carry != 0; i++)
        {
            result[i] = (byte)(b[i] + carry);
            carry = result[i] / 10;
            result[i] %= 10;
        }

        for (; i < b.Length; i++)
        {
            result[i] = b[i];
        }

        if (carry != 0)
        {
            result[i] = 1;
        }
        else
        {
            Array.Resize(ref result, result.Length - 1);
        }

        return result;
    }

    static byte[] Multiply(byte[] x, int y)
    {
        byte[] result = { 0 };
        for (int i = 0; i < y; i++)
        {
            result = Add(result, x);
        }

        return result;
    }
}