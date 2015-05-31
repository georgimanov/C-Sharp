using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands 
{
    using ConsoleForum.Contracts;

    public class ShowQuestionsCommand : AbstractCommand
    {
        public ShowQuestionsCommand(IForum forum) 
            : base(forum)
        {
        }

        public override void Execute()
        {
            if (this.Forum.Questions.Any())
            {
                var questions = this.Forum.Questions.OrderBy(x => x.Id);
                foreach (var question in questions)
                {
                    this.Forum.Output.AppendLine(question.ToString());
                }
            }
            else
            {
                this.Forum.Output.AppendLine(
                    String.Format(Messages.NoQuestions));
            }
        }
    }
}
