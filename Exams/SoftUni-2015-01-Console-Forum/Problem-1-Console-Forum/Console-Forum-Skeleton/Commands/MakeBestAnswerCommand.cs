namespace ConsoleForum.Commands
{
    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Posts;

    class MakeBestAnswerCommand : AbstractCommand
    {
        public MakeBestAnswerCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            var answerId = this.Data[1];

            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }

            if (this.Forum.CurrentQuestion == null)
            {
                throw new CommandException(Messages.NoQuestionOpened);
            }

            var currentUser = this.Forum.CurrentUser;

            this.Forum.Output.AppendLine(
                string.Format(Messages.BestAnswerSuccess, answerId));
        }
    }
}
