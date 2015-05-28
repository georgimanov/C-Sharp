namespace ConsoleForum.Entity.Post
{
    using System.Collections.Generic;

    using ConsoleForum.Interfaces;

    public abstract class Post : IPost
    {
        public Post(int id, string body, IUser author)
        {
            this.Id = id;
            this.Body = body;
            this.Author = author;
        }

        public int Id { get; set; }

        public string Body { get; set; }

        public IUser Author { get; set; }
    }
}
