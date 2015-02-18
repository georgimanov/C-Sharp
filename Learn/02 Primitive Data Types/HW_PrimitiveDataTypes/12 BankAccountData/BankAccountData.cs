//12 A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;
class BankAccountData
{
    static void Main(string[] args)
    {
        string firstName = "Ivan";
        string middleName = "Petrov";
        string lastName = "Ivanov";
        decimal balance = 1234.56m;
        string bankName = "Bulgarian Bank AD";
        string IBAN = "BG12 BGSF 1234 5678 9012 34";
        ulong creditCardNumberOne = 1234567890;
        ulong creditCardNumberTwo = 9876543210;
        ulong creditCardNumberThree = 2143658709;

        Console.WriteLine("Bank Account information");
        Console.WriteLine();
        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Middle name: {0}", middleName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Balance: {0}", balance);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", IBAN);
        Console.WriteLine("Credit card number 1: {0}", creditCardNumberOne);
        Console.WriteLine("Credit card number 2: {0}", creditCardNumberTwo);
        Console.WriteLine("Credit card number 3: {0}", creditCardNumberThree);
    }
}