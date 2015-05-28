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
            int questionId = Int16.Parse(this.Data[1]);

            var question = questions.Where(x => x.Id == questionId);

            this.Forum.Output.AppendLine(
               string.Format(question.ToString()));
        }
    }
}
