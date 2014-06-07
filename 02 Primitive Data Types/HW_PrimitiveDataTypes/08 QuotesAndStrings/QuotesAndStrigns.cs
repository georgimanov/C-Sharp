//08. Declare two string variables and assign them with following value:
//The "use" of quotations causes difficulties.
// Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their value was correctly defined.


using System;
class QuotesAndStrigns
{
    static void Main(string[] args)
    {
        string fisrtStringVariable = "The \"use\" of quotations causes difficulties."; //escpaing the " by \
        
        Console.WriteLine(fisrtStringVariable);
    
        string  secondStringVariable = @"The ""use"" of quotations causes difficulties."; //escaping using @ ... must double the ".. 
    
        Console.WriteLine(secondStringVariable);
    }
}

