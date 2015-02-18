/*
problem 7
Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:
x	y	inside	 
0	1	true	
-2	0	true	
-1	2	false	
1.5	-1	true	
-1.5	-1.5	false	
100	-30	false	
0	0	true	
0.2	-0.8	true	
0.9	-1.93	false	
1	1.655	true	

*/

using System;
class PointInsideCircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input x: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Input y: ");
        double y = double.Parse(Console.ReadLine());

        const double r = 2d;
        bool check = ((x * x) + (y * y)) <= r * r;
        Console.WriteLine("Point is inside the circle : {0}", check);
     }
}