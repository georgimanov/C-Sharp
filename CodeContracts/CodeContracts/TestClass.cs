namespace CodeContracts
{
    using System;
    using System.Diagnostics.Contracts;

    public class TestClass
    {
        public TestClass(string someString)
        {
            // Runs w/o installed Code Contracts ... the line below is skipped
            Contract.Requires(!string.IsNullOrEmpty(someString), "string cannot be null or emptry");
            
            // Requires ccrewrite
            // Contract.Requires<ArgumentNullException>(!string.IsNullOrEmpty(someString), "string cannot be null or emptry");

            this.SomeString = someString;
        }

        public string SomeString
        {
            get;
            private set;
        }

        public void Print()
        {
            Console.WriteLine(this.SomeString);
        }
    }
}
