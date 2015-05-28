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
    public class OpenQuestionCommand : AbstractCommand, IExecutable
    {
        public OpenQuestionCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            int id = int.Parse(this.Data[1]);

            if (!this.Forum.Questions.Any(q => q.Id == id))
            {
                throw new CommandException(Messages.NoQuestion);
            }

            var question = this.Forum.Questions.First(q => q.Id == id);

            this.Forum.CurrentQuestion = question;

            this.Forum.Output.AppendLine(question.ToString());
        }
    }
}
