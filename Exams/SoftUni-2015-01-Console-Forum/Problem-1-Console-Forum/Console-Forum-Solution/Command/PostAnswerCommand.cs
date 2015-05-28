using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Entity;
using ConsoleForum.Entity.Post;
using ConsoleForum.Interfaces;

namespace ConsoleForum.Command
{
    public class PostAnswerCommand : AbstractCommand, IExecutable
    {
        public PostAnswerCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            this.ValidateLoggedUser();

            if (this.Forum.CurrentQuestion == null)
            {
                throw new CommandException(Messages.NoQuestionOpened);
            }

            string body = this.Data[1];

            var answer = new Answer(
                 this.Forum.Answers.Any() ? this.Forum.Answers.Last().Id + 1 : 1,
                 body,
                 this.Forum.CurrentUser
            );

            this.Forum.Answers.Add(answer);
            this.Forum.CurrentQuestion.Answers.Add(answer);

            this.Forum.Output.AppendLine(string.Format(Messages.PostAnswerSuccess, answer.Id));
        }
    }
}
