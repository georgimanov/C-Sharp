using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            Console.WriteLine(date.DayOfWeek); ;
        }
    }
}
