namespace ConsoleForum.Entity.Post
{
    using System;
    using System.Text;

    using ConsoleForum.Interfaces;

    public class Answer : Post, IAnswer
    {
        private const char DefaultDelimiterSymbol = '-';
        private const int DefaultDelimiterCount = 20;

        public Answer(int id, string body, IUser author)
            : base(id, body, author)
        {
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string delimiter = new string(DefaultDelimiterSymbol, DefaultDelimiterCount);

            output.AppendLine("[ Answer ID: " + this.Id + " ]");
            output.AppendLine("Posted by: " + this.Author);
            output.AppendLine("Answer Body: " + this.Body);
            output.Append(delimiter);

            return output.ToString();
        }
    }
}
