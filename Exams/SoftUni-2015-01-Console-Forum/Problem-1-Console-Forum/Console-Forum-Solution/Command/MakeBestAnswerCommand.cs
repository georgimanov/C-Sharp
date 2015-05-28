using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Entity;
using ConsoleForum.Entity.Post;
using ConsoleForum.Entity.User;
using ConsoleForum.Interfaces;

namespace ConsoleForum.Command
{
    public class MakeBestAnswerCommand : AbstractCommand, IExecutable
    {
        public MakeBestAnswerCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }

            if (this.Forum.CurrentQuestion == null)
            {
                throw new CommandException(Messages.NoQuestionOpened);
            }

            int id = int.Parse(this.Data[1]);

            if (!this.Forum.CurrentQuestion.Answers.Any(a => a.Id == id))
            {
                throw new CommandException(Messages.NoAnswer);
            }

            var answer = this.Forum.Answers.First(a => a.Id == id);

            if (this.Forum.CurrentQuestion.Author.Id != this.Forum.CurrentUser.Id)
            {
                if (!(this.Forum.CurrentUser is Administrator))
                {
                    throw new CommandException(Messages.NoPermission);
                }
            }

            if (this.Forum.CurrentQuestion.Answers.Any(a => a is BestAnswer))
            {
                var bestAnswer = this.Forum.CurrentQuestion.Answers.First(a => a is BestAnswer) as BestAnswer;

                if (bestAnswer.Id != id)
                {
                    var normalAnswer = new Answer(bestAnswer.Id, bestAnswer.Body, bestAnswer.Author);

                    this.Forum.Answers.Remove(bestAnswer);
                    this.Forum.CurrentQuestion.Answers.Remove(bestAnswer);
                    
                    this.Forum.Answers.Add(normalAnswer);
                    this.Forum.CurrentQuestion.Answers.Add(normalAnswer);
                }
            }

            this.Forum.Answers.Remove(answer);
            this.Forum.CurrentQuestion.Answers.Remove(answer);

            var newAnswer = new BestAnswer(answer.Id, ((Answer) answer).Body, answer.Author);

            this.Forum.Answers.Add(newAnswer);
            this.Forum.CurrentQuestion.Answers.Add(newAnswer);

            this.Forum.Output.AppendLine(
                string.Format(Messages.BestAnswerSuccess, newAnswer.Id)
            );
        }
    }
}
