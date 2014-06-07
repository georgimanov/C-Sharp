/*
Problem 2.	Print Company Information
A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.
*/

using System;
class PrintCompanyInfo
{
    static void Main(string[] args)
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter company address: ");
        string comapanyAddress = Console.ReadLine();

        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Enter fax number: ");
        string faxNumber = Console.ReadLine();

        Console.Write("Enter website: ");
        string webSite = Console.ReadLine();

        Console.Write("Enter manager: ");
        string manager = Console.ReadLine();

        Console.WriteLine(
            "Company name : {0}" +
            "\nComapny address : {1}" +
            "\nPhone Number : {2}" +
            "\nFax Number : {3}" +
            "\nWeb Site : {4}" +
            "\nManager : {5}"
            , companyName, comapanyAddress, phoneNumber, faxNumber, webSite, manager);
    }
}