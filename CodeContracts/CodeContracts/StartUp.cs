namespace CodeContracts
{
    using System;

    public class StartUp
    {
        private static void Main(string[] args)
        {
            var test = new TestClass("");

            Console.WriteLine(test.SomeString);
        }
    }
}
