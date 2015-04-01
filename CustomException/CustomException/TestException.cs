namespace CustomException
{
    using System;

    public class TestException : ApplicationException
    {
        public override string Message
        {
            get { return "Something bad happened!"; }
        }

        public TestException()
        {
        }
    }
}
