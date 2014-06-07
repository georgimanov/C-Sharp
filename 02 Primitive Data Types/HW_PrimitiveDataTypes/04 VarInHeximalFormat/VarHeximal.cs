//04 Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure that the result is “254”.

using System;

class VarHeximal
{
    static void Main(string[] args)
    {
        int intVar = 254;
        Console.WriteLine("The hex value of {0} is {0:X}.", intVar);

        //Output: FE
    }
}

