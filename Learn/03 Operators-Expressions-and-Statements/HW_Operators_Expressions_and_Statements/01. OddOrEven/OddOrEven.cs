//01. Write an expression that checks if given integer is odd or even. Examples:
//n	Odd?
//3	true
//2	false
//-2	false
//-1	true
//0	false


using System;
class Program
{
    static void Main(string[] args)
    {
        int inputNumber = int.Parse(Console.ReadLine());  //read a 
        Console.WriteLine("{0}", (inputNumber % 2 == 0) ? "false" : "true"); //using Ternary operator to print the result. It can be also done with an If (...) else function.
    }
}
/*  
 *  another way to solve the problem: 
 *  
    if ( inputNumber % 2 == 0 ) -> check if the number is odd or even
    {
        Console.WriteLine("false");
    }
    else
    {
        Console.WriteLine("true");
    }
*/