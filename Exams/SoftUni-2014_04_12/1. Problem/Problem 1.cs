using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;


namespace _1.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime time = new DateTime();
            double hour = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            time = time.AddMinutes(minutes);

            string amOrPm = Console.ReadLine();
            switch (amOrPm)
            {
                case "AM": hour = hour + 0; break;
                case "PM" : hour = hour + 12; break;
                default:
                    break;
            }
            time = time.AddHours(hour);

            double additionaHours = double.Parse(Console.ReadLine());
            time = time.AddHours(additionaHours);

            double additionalMinutes = double.Parse(Console.ReadLine());
            time = time.AddMinutes(additionalMinutes);

            string stramOrPm ;
                if (time.Hour < 12)
                {
                    stramOrPm = "AM";
                }
           else
                {
                    stramOrPm = "PM";
                }


            Console.WriteLine(time.ToString("hh:mm:") + "{0}", stramOrPm);

        }
    }
}
