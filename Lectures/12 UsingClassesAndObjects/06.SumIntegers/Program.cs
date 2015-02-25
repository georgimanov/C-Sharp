using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] list = input.Split(new char[] { ' ', ',', '!' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = CalculateSum(list);
            Console.WriteLine("Sum : {0}", sum);
        }

        private static int CalculateSum(string[] list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum += int.Parse(item);
            }

            return sum;
        }
    }
}
