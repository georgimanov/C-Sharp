//Problem 5.	Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7. Examples:
//n	Third digit 7?
//5	false
//701	true
//9703	true
//877	false
//777877	false
//9999799	true


using System;
    class BoolThirdDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number to check if its third digit from right-to-left is 7 :"); //read number from console
            int inputNumber = int.Parse(Console.ReadLine()); //converto from string to integer
            int getThirdDigit = (inputNumber / 100) % 10; // get the third number
            bool check = getThirdDigit == 7; // check if true of false
            Console.WriteLine(check); // print result
        }
    }