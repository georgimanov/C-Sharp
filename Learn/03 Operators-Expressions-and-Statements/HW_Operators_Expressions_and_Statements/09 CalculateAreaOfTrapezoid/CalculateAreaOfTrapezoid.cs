/*Problem 9
Write an expression that calculates trapezoid's area by given sides a and b and height h. Examples:
a	    b	    h	    area	 
5	    7	    12	    72	
2	    1	    33	    49.5	
8.5	    4.3	    2.7	    17.28	
100	    200	    300	    45000	
0.222	0.333	0.555	0.1540125	
*/

using System;
    class CalculateAreaOfTrapezoid
    {
        static void Main(string[] args)
        {
            double a = 0.222;
            double b = 0.333;
            double h = 0.555;
            double area = (a + b) * (h / 2);
            Console.WriteLine(area);
        }
    }