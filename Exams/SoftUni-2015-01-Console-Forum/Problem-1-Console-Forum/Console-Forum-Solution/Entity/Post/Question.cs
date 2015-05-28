using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleForum.Interfaces;
using UserEntity = ConsoleForum.Entity.User;
namespace ConsoleForum.Entity.Post
{
    public class Question : Post, IQuestion
    {
        private const char DefaultDelimiterSymbol = '=';
        private const int DefaultDelimiterCount = 20;
        private const string AnswersHeader = "Answers:";
        private const string NoAnswersHeader = "No answers";

        public Question(int id, string body, IUser author, string title)
            : base(id, body, author)
        {
            this.Title = title;
            this.Answers = new List<IAnswer>();
        }

        public string Title { get; set; }

        public IList<IAnswer> Answers { get; set; }

        public IAnswer BestAnswer { get; set; }

        public override string ToString()
        {
            var answers = this.Answers.ToArray();
            answers = answers.OrderByDescending(a => a is BestAnswer).ToArray();

            StringBuilder output = new StringBuilder();

            output.AppendLine("[ Question ID: " + this.Id + " ]");
            output.AppendLine("Posted by: " + this.Author);
            output.AppendLine("Question Title: " + this.Title);
            output.AppendLine("Question Body: " + this.Body); 
            output.AppendLine(new string(DefaultDelimiterSymbol, DefaultDelimiterCount));

            if (answers.Any())
            {
                output.AppendLine(AnswersHeader);
                output.Append(string.Join<IPost>("\n", answers));
            }
            else
            {
                output.Append(NoAnswersHeader);
            }

            return output.ToString();
        }
    }
}
