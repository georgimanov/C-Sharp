namespace ConsoleForum.Command
{
    using System.Collections.Generic;

    using ConsoleForum.Interfaces;
    using ConsoleForum.Entity.User;

    public abstract class AbstractCommand : ICommand
    {
        public readonly List<string> Data = new List<string>();

        protected AbstractCommand(IForum forum)
        {
            this.Forum = forum;
        }

        public IForum Forum { get; private set; }

        public abstract void Execute();

        protected void ValidateLoggedUser()
        {
            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }
        }
    }
}
