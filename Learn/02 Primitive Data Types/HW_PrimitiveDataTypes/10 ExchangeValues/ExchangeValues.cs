//10. Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. Print the variable values before and after the exchange.

using System;
class ExchangeValues
{
    static void Main(string[] args)
    {
        int firstVariable = 5;
        int secondVariable = 10;
        int exchangeVariable; //for the exchange I am using a third variable.

        Console.WriteLine("Before exchange...");
        Console.WriteLine("First variable : {0}", firstVariable);
        Console.WriteLine("Second variable : {0}", secondVariable);

        exchangeVariable = firstVariable;
        firstVariable = secondVariable;
        secondVariable = exchangeVariable;

        Console.WriteLine();
        Console.WriteLine("After exchange...");
        Console.WriteLine("First variable : {0}", firstVariable);
        Console.WriteLine("Second variable : {0}", secondVariable);
    }
}

