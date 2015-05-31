namespace ConsoleForum.Commands 
{
    using ConsoleForum.Contracts;
    using ConsoleForum.Entities.Posts;

    class PostQuestionCommand : AbstractCommand
    {
        public PostQuestionCommand(IForum forum) 
            : base(forum)
        {
        }

        public override void Execute()
        {
            var questions = this.Forum.Questions;
            var questionTitle = this.Data[1];
            var questionBody = this.Data[2];
            IUser currentUser = this.Forum.CurrentUser;

            if (currentUser == null)
            {
                throw new CommandException(Messages.NotLogged);
            }

            var question = new Question(questions.Count + 1, questionTitle, questionBody, currentUser);
            this.Forum.Questions.Add(question);

            this.Forum.Output.AppendLine(
                    string.Format(Messages.PostQuestionSuccess, question.Id));
        }
    }
}
