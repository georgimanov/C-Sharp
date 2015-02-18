using System;

class Program
{
    static void Main(string[] args)
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        
        long maxOfThree = long.MinValue;
        if (a >= b && a >= c)
        {
            maxOfThree = a;
        }
        else if (b >= a && b >= c)
        {
            maxOfThree = b;
        }
        else if (c >= a && c >= b)
        {
            maxOfThree = c;
        }

        long minOfThree = long.MaxValue;
        if (a <= b && a <= c)
        {
            minOfThree = a;
        }
        else if (b <= a && b <= c)
        {
            minOfThree = b;
        }
        else if (c <= a && c <= b)
        {
            minOfThree = c;
        }

        double sum = a + b + c;
        double arithmeticMean = sum / 3;
        Console.WriteLine(maxOfThree);
        Console.WriteLine(minOfThree);
        Console.WriteLine("{0:F2}",arithmeticMean);
    }
}