using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Entity;
using ConsoleForum.Entity.User;

namespace ConsoleForum.Interfaces
{
    public interface IPost
    {
        int Id { get; set; }

        string Body { get; set; }

        IUser Author { get; set; }
    }
}
