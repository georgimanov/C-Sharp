using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Participant
    {
        public Participant(string name)
        {
            this.Name = name;
        }

        public AbstractControllingTower ControllingTower { get; set; }

        public string Name { get; set; }

        public void Send(string to, string message)
        {
            this.ControllingTower.Send(this.Name, to, message);
        }

        public void SendToAll(string message)
        {
            this.ControllingTower.SendToAll(this.Name, message);
        }

        public void Receive(string from, string message)
        {
            Console.WriteLine("To a {3}: {0} to {1}: '{2}'", from, this.Name, message, this.GetType().Name);
        }
    }
}
