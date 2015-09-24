using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    using System.Runtime.CompilerServices;

    class Program
    {
        static void Main(string[] args)
        {
            LoggerDemo();
            LoggerDemoTwo();
            Console.WriteLine("Demo finished");
        }

        private static void LoggerDemo()
        {
            var logger = new FileLogger("..\\..\\log.txt");
            var doSomething = new DoSomething(logger);
            doSomething.Work();
        }

        private static void LoggerDemoTwo()
        {
            var logger = new ConsoleLogger();
            var doSomething = new DoSomething(logger);
            doSomething.Work();
        }
    }
}
