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
                this.Forum.Output.AppendLine(
                    string.Format(this.Forum.Questions.ToString())
                    );

                if (this.Forum.CurrentQuestion.Answers.Any())
                {
                    this.Forum.Output.AppendLine(
                        string.Format(this.Forum.CurrentQuestion.Answers.ToString())
                        );
                }
                else
                {
                    this.Forum.Output.AppendLine(
                        string.Format(Messages.NoAnswer));
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
