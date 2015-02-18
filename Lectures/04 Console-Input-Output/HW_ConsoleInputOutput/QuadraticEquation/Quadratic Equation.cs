/*
Problem 6.	Quadratic Equation
Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). Examples: 
a	    b	    C	    Roots
2	    5	    -3	    x1=-3; x2=0.5
-1	    3	    0	    x1=3; x2=0
-0.5	4	    -8	    x1=x2=4
5	    2	    8	    no real roots

 ------/------
 The roots of a quadratic function are given by,
 x1 = (- b + sqrt( b^2 - 4ac) ) / 2a
 x2 = (- b - sqrt( b^2 - 4ac) ) / 2a

discriminant = b^2 - 4ac 

1. b2 −4ac < 0 There are no real roots.

2. b2 −4ac = 0 There is one real root.

3. b2 −4ac > 0 There are two real roots.
*/


using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter coefficients a, b and c of a quadratic equation a * x ^ 2 + b * x + c = 0");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        double xOne;
        double xTwo;

        double discriminant = (b * b) - (4 * a * c);
        
        if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("There is one real root.");
            xOne = (-b + Math.Sqrt( discriminant )) / (2 * a);
            Console.WriteLine("X1 = {0}",xOne);
        }
        else
        {
            Console.WriteLine("There are two real roots.");
            xOne = (-b + Math.Sqrt(discriminant)) / (2 * a);
            xTwo = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("X1 = {0}", xOne);
            Console.WriteLine("X2 = {0}", xTwo);
        }
    }
}