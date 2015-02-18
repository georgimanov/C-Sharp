/*
Problem 10.	Odd and Even Product
You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc. Examples:
numbers	        result
 * 
2 1 1 6 3	    yes
                product = 6
 * 
3 10 4 6 5 1	yes
                product = 60
 * 
4 3 2 5 2	    no
                odd_product = 16
                even_product = 15
*/

using System;

class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter values: ");
        string inputStr = Console.ReadLine();
        
        char[] separator = {' '};
        
        string[] newArr = inputStr.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        int[] myIntArr = new int[newArr.Length];
        
        for (int i = 0; i < newArr.Length; i++)
        {
            myIntArr[i] = int.Parse(newArr[i]);
        }

        long odd_product = 1;
        long even_product = 1;

        for (int i = 0; i < myIntArr.Length; i++)
        {
            if (i % 2 == 0)
                odd_product *= myIntArr[i];
            if (i % 2 != 0)
                even_product *= myIntArr[i];

        }
        if (odd_product == even_product)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", even_product);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", odd_product);
            Console.WriteLine("even_product = {0}", even_product);
        }
    }
}

/*numbers	        result
 * 
2 1 1 6 3	    yes
                product = 6
 * 
3 10 4 6 5 1	yes
                product = 60
 * 
4 3 2 5 2	    no
                odd_product = 16
                even_product = 15
*/