using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var sofiaControlTower = new ControllingTower();

            var boeing747 = new Airplane("747");
            var boeing737 = new Airplane("737");
            var bigRedBus = new NonAriplane("Red");

            sofiaControlTower.Register(boeing737);
            sofiaControlTower.Register(boeing747);
            sofiaControlTower.Register(bigRedBus);

            boeing737.Send("Red", "Hi, Red!");
            bigRedBus.Send("737", "Wat's up, Dude?");
            boeing737.Send("747", "Hi, Bro!");
            bigRedBus.Send("747", "Ready to land?");
            boeing747.SendToAll("Hi, All :) !");
        }
    }
}
