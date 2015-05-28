namespace ConsoleForum.Interfaces
{
    using System.Collections.Generic;

    public interface IQuestion : IPost
    {
        string Title { get; set; }

        IAnswer BestAnswer { get; set; }

        IList<IAnswer> Answers { get; }
    }
}
