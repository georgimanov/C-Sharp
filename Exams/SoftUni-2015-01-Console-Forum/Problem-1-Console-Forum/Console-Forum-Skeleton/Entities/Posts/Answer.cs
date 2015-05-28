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
    }
}
