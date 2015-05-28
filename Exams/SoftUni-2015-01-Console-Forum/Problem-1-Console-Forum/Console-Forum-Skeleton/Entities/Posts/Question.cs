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
        public IList<IAnswer> Answers { get; private set; }
    }
}
