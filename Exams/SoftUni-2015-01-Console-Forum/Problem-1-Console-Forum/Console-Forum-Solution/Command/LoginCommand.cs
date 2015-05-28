using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Entity;
using ConsoleForum.Entity.User;
using ConsoleForum.Interfaces;
using ConsoleForum.Utility;

namespace ConsoleForum.Command
{
    public class LoginCommand : AbstractCommand, IExecutable
    {
        public LoginCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            if (this.Forum.IsLogged)
            {
                throw new CommandException(Messages.AlreadyLoggedIn);
            }

            string username = this.Data[1];
            string password = PasswordUtility.Hash(this.Data[2]);

            var user = this.Forum.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user == null)
            {
                throw new CommandException(Messages.InvalidLoginDetails);
            }

            this.Forum.CurrentUser = user;

            this.Forum.Output.AppendLine(
                string.Format(Messages.LoginSuccess, username)
            );
        }
    }
}
