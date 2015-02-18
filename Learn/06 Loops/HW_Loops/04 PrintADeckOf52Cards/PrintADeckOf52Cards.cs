/*
Problem 4.	Print a Deck of 52 Cards
Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5♠, A♥, 9♣ and K♦). The card faces should start from 2 to A. Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
output
2♣ 2♦ 2♥ 2♠
3♣ 3♦ 3♥ 3♠
…
K♣ K♦ K♥ K♠
A♣ A♦ A♥ A♠
*/

using System;
class PrintADeckOf52Cards
{
    static void Main(string[] args)
    {
        char[] cardSign = {'♣', '♦', '♥', '♠' };
        string[] cardNumber = {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
        for (int i = 0; i < cardNumber.Length; i++)
        {
            for (int j = 0; j < cardSign.Length; j++)
            {
                Console.Write("{0}{1} ",cardNumber[i], cardSign[j]);
            }
            Console.WriteLine();
        }
    }
}