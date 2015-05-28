using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands 
{
    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Posts;
    using ConsoleForum.Entities.Users;

    class PostQuestionCommand : AbstractCommand
    {
        public PostQuestionCommand(IForum forum) 
            : base(forum)
        {
        }

        public override void Execute()
        {
            var questions = this.Forum.Questions;
            var questionTitle = this.Data[1];
            var questionBody = this.Data[2];


            var question = new Question(questions.Count + 1, questionTitle, questionBody, new User(2, "a", "pass", "a@a.a"));
        }
    }
}
