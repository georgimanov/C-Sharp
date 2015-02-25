using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TriangleSurface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("h: ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("angle: ");
            double angle = double.Parse(Console.ReadLine());
            double radians = angle * Math.PI / 180;
            Console.WriteLine("a * h / 2 = {0} ", a * h / 2);
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Math.Sqrt(p * (p - a) * (p - b) * (p - c)) = {0}", area);
            area = (a * b * Math.Sin(radians) / 2 );
            Console.WriteLine("(a * b * Math.Sin(radians) / 2 = {0}", area);
        }
    }
}
