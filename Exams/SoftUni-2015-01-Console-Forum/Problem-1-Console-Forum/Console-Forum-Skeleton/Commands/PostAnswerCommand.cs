using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;

namespace ConsoleForum.Commands
{
    public class PostAnswerCommand : AbstractCommand
    {
        public PostAnswerCommand(IForum forum) 
            : base(forum)
        {
        }

        public override void Execute()
        {
            var answerBody = this.Data[1];
            
            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }

            if (this.Forum.CurrentQuestion == null)
            {
                throw new CommandException(Messages.NoQuestionOpened);
            }

            var answers = this.Forum.Answers;
            var newAnswerId = answers.Count + 1;
            var currentUser = this.Forum.CurrentUser;
            var answer = new Answer(newAnswerId, answerBody, currentUser);

            this.Forum.CurrentQuestion.Answers.Add(answer);

            this.Forum.Output.AppendLine(
                string.Format(Messages.PostAnswerSuccess, newAnswerId));
        }
    }
}
