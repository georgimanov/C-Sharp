using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Entities.Posts {
    using ConsoleForum.Contracts;

    public class Answer : Post, IAnswer 
    {
        public Answer(int id, string body, IUser author) 
            : base(id, body, author)
        {
        }

        public override string ToString()
        {
            var baseString = base.ToString();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format(new string('*', 20)));
            sb.AppendLine(baseString.Trim());
            sb.AppendLine(string.Format("{0} Body: {1}", this.GetType().Name, this.Body));
            sb.AppendLine(String.Format(new string('-', 20)));
            
            return sb.ToString();
        }
    }
}
