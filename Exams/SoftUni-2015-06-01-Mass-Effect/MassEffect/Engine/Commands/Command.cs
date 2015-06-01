namespace MassEffect.Engine.Commands
{
    using System;
    using System.Linq;

    using MassEffect.Interfaces;

    public class Command
    {
        public Command(IGameEngine gameEngine)
        {
            this.GameEngine = gameEngine;
        }

        public IGameEngine GameEngine { get; set; }

        public virtual void Execute(string[] commandArgs)
        {
            throw new NotImplementedException();
        }

        public IStarship GetStarshipByName(string starshipName)
        {
            var starship = this.GameEngine
                .Starships
                .FirstOrDefault(x => x.Name == starshipName); ;

            return starship;
        }
    }
}
