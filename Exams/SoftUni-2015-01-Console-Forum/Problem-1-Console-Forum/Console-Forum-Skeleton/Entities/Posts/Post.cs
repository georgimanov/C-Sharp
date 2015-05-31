using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Entities.Posts 
{
    using ConsoleForum.Contracts;

    public abstract class Post : IPost
    {
        protected Post(int id, string body, IUser author)
        {
            this.Id = id;
            this.Body = body;
            this.Author = author;
        }

        public int Id { get; set; }
        public string Body { get; set; }
        public IUser Author { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("[ {0} ID: {1} ]", this.GetType().Name, this.Id));
            sb.AppendLine(string.Format("Posted by: {0}", this.Author.Username));
            
            return sb.ToString();
        }
    }
}
