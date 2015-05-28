using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Command
{
    using ConsoleForum.Entity.Post;
    using ConsoleForum.Interfaces;

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
                var questions = this.Forum.Questions.ToArray();
                this.Forum.CurrentQuestion = null;
                this.Forum.Output.AppendLine(string.Join<IPost>("\n", questions));
            }
            else
            {
                this.Forum.Output.AppendLine(Messages.NoQuestions);
            }
        }
    }
}
