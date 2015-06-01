namespace MassEffect.Engine.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MassEffect.Interfaces;

    public class SystemReportCommand : Command
    {
        public SystemReportCommand(IGameEngine gameEngine) 
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string command = commandArgs[0];
            string starsSystem = commandArgs[1];

            var intactShips = this.GameEngine
                .Starships
                .Where(s => s.Location.Name == starsSystem && s.Health > 0)
                .OrderByDescending(s => s.Health)
                .ThenByDescending(s => s.Shields);

            var destroyedShips = this.GameEngine
               .Starships
               .Where(s => s.Location.Name == starsSystem && s.Health <= 0)
               .OrderBy(s => s.Name);

            Console.WriteLine("Intact ships:");
            if (intactShips.Any())
            {
                foreach (var ship in intactShips)
                {
                    Console.WriteLine(ship.ToString());
                }
            }
            else
            {
                Console.WriteLine("N/A");
            }

            Console.WriteLine("Destroyed ships:");
            if (destroyedShips.Any())
            {
                foreach (var ship in destroyedShips)
                {
                    Console.WriteLine(ship.ToString());
                }
            }
            else
            {
                Console.WriteLine("N/A");
            }
            
        }
    }
}
