using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Contracts;
using ConsoleForum.Utility;

namespace ConsoleForum.Commands
{
    using ConsoleForum.Entities.Users;

    public class LoginCommand : AbstractCommand, ICommand
    {
        public LoginCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            var users = this.Forum.Users;
            string username = this.Data[1];
            string password = PasswordUtility.Hash(this.Data[2]);

            if (this.Forum.IsLogged)
            {
                throw new CommandException(Messages.AlreadyLoggedIn);
            }

            if (!users.Any(u => u.Username == username && u.Password == password))
            {
                throw new CommandException(Messages.InvalidLoginDetails);
            }

            this.Forum.CurrentUser = this.Forum.Users.FirstOrDefault(x => x.Username == username);
            
            this.Forum.Output.AppendLine(
                    string.Format(Messages.LoginSuccess, username));
        }
    }
}