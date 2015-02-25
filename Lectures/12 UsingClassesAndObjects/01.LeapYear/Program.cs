using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} is leap year {1}", input, DateTime.IsLeapYear(input));
        }
    }
}
