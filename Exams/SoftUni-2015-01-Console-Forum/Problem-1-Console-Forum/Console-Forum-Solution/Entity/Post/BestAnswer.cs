namespace ConsoleForum.Entity.Post
{
    using System;
    using System.Text;

    using ConsoleForum.Interfaces;

    public class BestAnswer : Answer
    {
        private const char DefaultDelimiterSymbol = '*';
        private const int DefaultDelimiterCount = 20;

        public BestAnswer(int id, string body, IUser author) 
            : base(id, body, author)
        {
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine(new string(DefaultDelimiterSymbol, DefaultDelimiterCount));
            output.AppendLine(base.ToString());
            output.Append(new string(DefaultDelimiterSymbol, DefaultDelimiterCount));

            return output.ToString();
        }
    }
}
