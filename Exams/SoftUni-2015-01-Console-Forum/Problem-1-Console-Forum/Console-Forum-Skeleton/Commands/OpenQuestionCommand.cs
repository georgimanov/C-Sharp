using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands 
{
    using ConsoleForum.Contracts;

    public class OpenQuestionCommand : AbstractCommand
    {
        public OpenQuestionCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            var questions = this.Forum.Questions;
            int questionId = int.Parse(this.Data[1]);

            var question = questions.FirstOrDefault(x => x.Id == questionId);

            if (question == null)
            {
                this.Forum.Output.AppendLine(
                    string.Format(Messages.NoQuestionOpened));
            }
            else
            {
                this.Forum.CurrentQuestion = question;
             
                this.Forum.Output.AppendLine(
                   string.Format(question.ToString()));
            }
        }
    }
}
