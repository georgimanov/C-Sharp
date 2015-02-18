/*
Problem 10.	Point Inside a Circle & Outside of a Rectangle
Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). Examples:
x	y	inside K & outside of R	 
1	2	yes	
2.5	2	no	
0	1	no	
2.5	1	no	
2	0	no	
4	0	no	
2.5	1.5	no	
2	1.5	yes	
1	2.5	yes	
-100	-100	no	
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input x: ");
        double x = double.Parse(Console.ReadLine());
      
        Console.WriteLine("Input y: ");
        double y = double.Parse(Console.ReadLine());
        
        const double r = 1.5d;
        double xCircle = x - 1; //declaring new variables in order to "change" the position of the Circle K({0, 0}, 1.5)
        double yCircle = y - 1;


        bool pointInCirle = ((xCircle * xCircle) + (yCircle * yCircle)) <= (r * r); //check position of point according to Circle
        // Console.WriteLine("Point is inside the circle : {0}", pointInCirle);

        bool pointInRectangle = (-1 <= x) && (x <= 5) && (-1 <= y) && (y <= 1); //check position of point according to Rectangle
        // Console.WriteLine("Point is inside the rectangle : {0}", pointInRectangle);

        if ( pointInCirle == true && pointInRectangle == false)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}