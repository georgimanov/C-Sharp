namespace ConsoleForum
{
    using System;
    using System.Text;
    using System.Linq;
    using ConsoleForum.Entity.Post;

    public class AdvancedForum : Forum
    {
        private const char HeaderDelimiter = '~';
        private const int HeaderBorderLength = 20;

        protected override void ExecuteCommandLoop()
        {
            string header = this.GenerateHeader();
            Console.WriteLine(header);

            base.ExecuteCommandLoop();
        }

        private string GenerateHeader()
        {
            StringBuilder headerOutput = new StringBuilder();

            headerOutput.AppendLine(new string(HeaderDelimiter, HeaderBorderLength));

            string welcomeMessage = this.IsLogged ? string.Format(Messages.UserWelcomeMessage, this.CurrentUser) : Messages.GuestWelcomeMessage;

            var hotQuestionsCount = this.Questions
                .Where(q => q.Answers
                    .Any(a => a is BestAnswer))
                .Count();
            //var activeUsersCount = this.Users
            //    .Where(u => u.Questions.Count > 1)
            //    .Count();
            var activeUsersCount = this.Users
                .Join(this.Answers,
                    u => u.Id,
                    a => a.Author.Id,
                    (u, a) => new { User = u, Answer = a })
                .GroupBy(x => x.User.Id)
                .Where(x => x.Count() >= 3)
                .Count();
                
                
            string generalHeader = string.Format(Messages.GeneralHeaderMessage, hotQuestionsCount, activeUsersCount);

            headerOutput.AppendLine(string.Format("{0}\n{1}", welcomeMessage, generalHeader));
            headerOutput.Append(new string(HeaderDelimiter, HeaderBorderLength));

            return headerOutput.ToString();
        }
    }
}
