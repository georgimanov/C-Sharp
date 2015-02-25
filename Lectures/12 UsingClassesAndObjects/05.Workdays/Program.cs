using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        DateTime startDate = new DateTime(2015, 01, 01);
        DateTime endDate = new DateTime(2015, 12, 31);

        int workingDays = GetWorkingDaysInRange(startDate, endDate);
        Console.WriteLine("There are {0} working days between \n{1} and {2}", workingDays, startDate, endDate);
    }

    // for double check http://www.kik-info.com/useful_info/calendar/2015/
    // 252 working days for 2015

    public static int GetWorkingDaysInRange(DateTime startDate, DateTime endDate)
    {
        int countDaysInRange = 0;

        if (endDate < startDate)
        {
            throw new ArgumentException("End date must be greater than or equal to start date");
        }

        while (startDate < endDate)
        {
            startDate = startDate.AddDays(1);
            if (!IsHoliday(startDate) && 
                startDate.DayOfWeek != DayOfWeek.Saturday && 
                startDate.DayOfWeek != DayOfWeek.Sunday)
            {
                countDaysInRange++;
            }
            else if (IsWorkingSaturday(startDate))
            {
                countDaysInRange++;
            }
        }

        return countDaysInRange;
    }

    public static bool IsHoliday(DateTime date)
    {
        DateTime[] holidays =
            new DateTime[] { 
                new DateTime(2015,01,01),
                new DateTime(2015,01,02),
                new DateTime(2015,03,03),
                new DateTime(2015,04,10),
                new DateTime(2015,04,11),
                new DateTime(2015,04,12),
                new DateTime(2015,04,13),
                new DateTime(2015,05,01),
                new DateTime(2015,05,06),
                new DateTime(2015,09,21),
                new DateTime(2015,09,22),
                new DateTime(2015,12,24),
                new DateTime(2015,12,25),
                new DateTime(2015,12,26),
                new DateTime(2015,12,31) 
            };

        return holidays.Contains(date.Date);
    }

    public static bool IsWorkingSaturday(DateTime date)
    {
        DateTime[] holidays =
            new DateTime[] { 
                new DateTime(2015,01,24),
                new DateTime(2015,03,21),
                new DateTime(2015,09,12),
                new DateTime(2015,12,12) 
            };

        return holidays.Contains(date.Date);
    }
}
