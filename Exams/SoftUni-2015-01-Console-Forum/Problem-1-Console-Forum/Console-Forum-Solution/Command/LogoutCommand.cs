namespace ConsoleForum.Command
{
    using System;

    using ConsoleForum.Interfaces;

    public class LogoutCommand : AbstractCommand, IExecutable
    {
        public LogoutCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            this.ValidateLoggedUser();

            this.Forum.CurrentUser = null;
            this.Forum.CurrentQuestion = null;
            this.Forum.Output.AppendLine(Messages.LogoutSuccess);
        }
    }
}
