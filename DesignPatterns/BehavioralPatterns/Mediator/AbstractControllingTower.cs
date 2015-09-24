using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public abstract class AbstractControllingTower
    {
        public abstract void Register(Participant participant);

        public abstract void Send(string from, string to, string message);

        public abstract void SendToAll(string from, string message);
    }
}
