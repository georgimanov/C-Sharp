using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Entities.Posts 
{
    using ConsoleForum.Contracts;

    public class Question : Post, IQuestion 
    {
        public Question(int id, string title, string body, IUser author) 
            : base(id, body, author)
        {
            this.Title = title;
            this.Answers = new List<IAnswer>();
        }

        public string Title { get; set; }

        public Answer BestAnswer { get; set; }

        public IList<IAnswer> Answers { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("{0} Title: {1}", this.GetType().Name, this.Title));
            sb.AppendLine(string.Format("{0} Body: {1}", this.GetType().Name, this.Body));
            sb.AppendLine(new string('=', 20));

            if (this.Answers.Any())
            {
                sb.AppendLine("Answers:");
                var answers = this.Answers.OrderBy(a => a.Id);
                foreach (var answer in answers)
                {
                    sb.AppendLine(answer.ToString());
                }
            }
            else
            {
                sb.AppendLine("No answers");
            }

            return base.ToString() + sb.ToString().Trim();
        }
    }
}
