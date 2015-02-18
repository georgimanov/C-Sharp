/*
Problem 9.	Play with Int, Double and String
Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement. Example: see homework
*/

using System;
class UsersChoiceInput
{
    static void Main(string[] args)
    {
        Console.WriteLine(""+
            "Please choose a type:" +
            "\n1 --> int" +
            "\n2 --> double" +
            "\n3 --> string");
        int usersChoise = int.Parse(Console.ReadLine());
        if (usersChoise == 1)
        {
            Console.Write("Please enter a integer: "); //increase by one
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number + 1);
        }
        else if ( usersChoise == 2)
        {
            Console.Write("Please enter a double: "); //increase by one
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(number + 1);
        }
        else if ( usersChoise == 3)
        {
            Console.Write("Please enter a string: "); //append *
            string str = Console.ReadLine();
            str = str + "*";
            Console.WriteLine(str);
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
}