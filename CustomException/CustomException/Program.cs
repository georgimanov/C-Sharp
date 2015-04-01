using System;
using System.Collections.Generic;
using System.IO;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new TestException();
            }
            catch (TestException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
