//13 Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.

using System;
class NullValues
{
    static void Main(string[] args)
    {
        int? nullInteger = null;
        double? nullDouble = null;

        Console.WriteLine("Null integer = {0}",nullInteger);
        Console.WriteLine("Null double = {0}", nullDouble);
    }
}