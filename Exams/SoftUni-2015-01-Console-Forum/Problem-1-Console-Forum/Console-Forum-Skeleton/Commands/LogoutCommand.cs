using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForum.Commands 
{
    using ConsoleForum.Contracts;

    public class LogoutCommand : AbstractCommand 
    {
        public LogoutCommand(IForum forum) 
            : base(forum)
        {
        }

        public override void Execute()
        {
            this.Forum.Output.AppendLine(
                string.Format(Messages.LogoutSuccess)
                );
        }
    }
}
