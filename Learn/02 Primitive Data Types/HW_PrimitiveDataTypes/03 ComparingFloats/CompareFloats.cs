//03 Write a program that safely compares floating-point numbers with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. Examples:

using System;
class CompareFloats

{
    static void Main(string[] args)
    {
        float a = 5.3f;
        float b = 6.01f;
            
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("a = b ? {0}", a == b); //output: false
        Console.WriteLine();

        a = 5.00000001f; //assigning new values
        b = 5.00000003f; //assigning new values
           
        Console.WriteLine("a = {0}", a); 
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("a = b ? {0}", a == b); //output: true
        Console.WriteLine();

        a = -0.0000007f; //assigning new values
        b = 0.00000007f; //assigning new values
            
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("a = b ? {0}", a == b); //output: false
        Console.WriteLine();

        a = -4.999999f; //assigning new values
        b = -4.999998f; //assigning new values

        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("a = b ? {0}", a == b); //output: false
        Console.WriteLine();
    }
}