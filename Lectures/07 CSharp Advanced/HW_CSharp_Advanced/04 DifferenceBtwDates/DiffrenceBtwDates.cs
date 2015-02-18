/*
Problem 4.	Difference between Dates
Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. Examples:
First date
Second date	Days between
17.03.2014
30.04.2014	44
17.03.2014
17.03.2014	0
14.06.1980
5.03.2014	12317
5.03.2014
C	-2
*/

using System;
class DiffrenceBtwDates
{
    static void Main(string[] args)
    {
        DateTime dateA = new DateTime();
        DateTime dateB = new DateTime();

        Console.WriteLine("Enter first date:");
        string input = Console.ReadLine();
        dateA = Convert.ToDateTime(input);

        Console.WriteLine("Enter second date:");
        input = Console.ReadLine();
        dateB = Convert.ToDateTime(input);

        int daysDifference = 0;

        if (dateB.Year == dateA.Year)
        {
            daysDifference = (dateB.DayOfYear - dateA.DayOfYear);
        }
        else
        {
            int yearsDiff = dateB.Year - dateA.Year;
            int countleapYears = 0;
            for (int i = 0; i <= yearsDiff; i++)
            {
                DateTime checkLeap = dateA.AddYears(i);
                if (DateTime.IsLeapYear(checkLeap.Year))
                {
                    countleapYears++;
                }
            }

            if (dateA < dateB)
            {
                daysDifference = (dateB.DayOfYear - dateA.DayOfYear) + yearsDiff * 365 + countleapYears;
            }
            else
            {
                daysDifference = - Math.Abs( (dateB.DayOfYear - dateA.DayOfYear) + yearsDiff * 365 + countleapYears);

            }
        }
        Console.WriteLine(daysDifference);
    }
}