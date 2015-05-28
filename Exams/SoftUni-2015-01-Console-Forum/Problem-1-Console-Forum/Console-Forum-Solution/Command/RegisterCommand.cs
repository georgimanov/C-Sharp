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
    public class RegisterCommand : AbstractCommand
    {
        public RegisterCommand(IForum forum)
            : base(forum)
        {
        }


        public override void Execute()
        {
            var users = this.Forum.Users;
            string username = this.Data[1];
            string password = PasswordUtility.Hash(this.Data[2]);
            string email = this.Data[3];

            if (users.Any(u => u.Username == username || u.Email == email))
            {
                throw new CommandException(Messages.UserAlreadyRegistered);
            }

            User user;

            if (this.Data.Count > 4)
            {
                var role = this.Data[4];

                switch (role.ToLower())
                {
                    case "administrator":
                        if (users.Any())
                        {
                            throw new CommandException(Messages.RegAdminNotAllowed);
                        }
                        user = new Administrator(users.Any() ? users.Last().Id + 1 : 1, username, password, email);
                        break;
                    default:
                        user = new User(users.Any() ? users.Last().Id + 1 : 1, username, password, email);
                        break;
                }
            }
            else
            {
                user = new User(users.Any() ? users.Last().Id + 1 : 1, username, password, email);
            }

            users.Add(user);

            this.Forum.Output.AppendLine(
                string.Format(Messages.RegisterSuccess, username, users.Last().Id)
            );
        }
    }
}
