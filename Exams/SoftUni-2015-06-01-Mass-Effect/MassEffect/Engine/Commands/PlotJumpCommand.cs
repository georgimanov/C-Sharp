namespace MassEffect.Engine.Commands
{
    using System;
    using System.Linq;

    using MassEffect.Interfaces;
    using MassEffect.GameObjects.Locations;

    public class PlotJumpCommand : Command
    {
        public PlotJumpCommand(IGameEngine gameEngine)
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            string starshipName = commandArgs[1];
            string destination = commandArgs[2];

            var starship = GetStarshipByName(starshipName);
            var startLocation = starship.Location.Name;

            if (starship.Health <= 0)
            {
                Console.WriteLine(Messages.ShipDestroyed, starship.Name);
                return;
            }

            if (starship.Location == this.GameEngine.Galaxy.GetStarSystemByName(destination))
            {
                Console.WriteLine(Messages.ShipAlreadyInStarSystem, starship.Location.Name);
                return;
            }

            this.GameEngine.Galaxy.TravelTo(starship, this.GameEngine.Galaxy.GetStarSystemByName(destination));

            Console.WriteLine(Messages.ShipTraveled, starship.Name, startLocation, destination);
        }
    }
}
