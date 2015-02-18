//04 Problem 4.	Rectangles
/* 
Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:
width	height	perimeter	area
3	    4	    14	        12
2.5	    3	    11	        7.5
5	    5	    20	        25

 */

using System;
class PerimenterOfRectangle
{
    static void Main(string[] args)
    {
        Console.Write("Please input rectangle’s width: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Please input rectangle’s height: ");
        float height = float.Parse(Console.ReadLine());
        float perimeter = 2 * width + 2 * height;
        float area = width * height ;
        Console.WriteLine("Rectangle’s perimeter is {0} \nRectangle’s area is {1}", 
            perimeter, area);
    }
}