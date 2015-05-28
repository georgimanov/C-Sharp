using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Interfaces;

namespace ConsoleForum.Command
{
    public class ExitCommand : AbstractCommand, IExecutable
    {
        public ExitCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            this.Forum.HasStarted = false;
        }
    }
}
