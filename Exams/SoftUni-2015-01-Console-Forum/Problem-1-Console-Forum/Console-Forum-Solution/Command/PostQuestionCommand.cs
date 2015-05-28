using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Entity;
using ConsoleForum.Entity.Post;
using ConsoleForum.Interfaces;

namespace ConsoleForum.Command
{
    public class PostQuestionCommand : AbstractCommand, IExecutable
    {
        public PostQuestionCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            this.ValidateLoggedUser();

            var questions = this.Forum.Questions;

            string title = this.Data[1];
            string body = this.Data[2];

            var question = new Question(
                 questions.Any() ? questions.Last().Id + 1 : 1,
                 body,
                 this.Forum.CurrentUser,
                 title
            );

            this.Forum.CurrentUser.Questions.Add(question);
            questions.Add(question);

            this.Forum.Output.AppendLine(
                string.Format(Messages.PostQuestionSuccess, question.Id)
            );
        }
    }
}
