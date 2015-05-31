using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Users
{
    public class Guest 
    {
        public Guest(string author)
        {
            this.Author = author;
        }

        public string Author { get; set; }
    }
}
