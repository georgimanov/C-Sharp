using System;
using MassEffect.Engine.Factories;
using MassEffect.GameObjects.Enhancements;
using MassEffect.GameObjects.Locations;
using MassEffect.GameObjects.Ships;

namespace MassEffect.Engine.Commands
{
    using MassEffect.Interfaces;

    public class CreateCommand : Command
    {
        public CreateCommand(IGameEngine gameEngine) 
            : base(gameEngine)
        {
        }

        public override void Execute(string[] commandArgs)
        {
            //create {shipType} {shipName} {starSystem} {enhancement1 enhancements2 ...} 

            StarshipType starshipType = CastStringToStarshipType(commandArgs[1]);
            string starshipName = commandArgs[2];

            if (GetStarshipByName(starshipName) != null)
            {
                Console.WriteLine(Messages.DuplicateShipName);
            }
            
            
            string starshipLocation = commandArgs[3];

            var ship = new ShipFactory();

            IStarship starship = ship.CreateShip(starshipType, starshipName, this.GameEngine.Galaxy.GetStarSystemByName(starshipLocation));

            if (commandArgs.Length > 3)
            {
                var enhancementFactory = new EnhancementFactory();
                for (int i = 4; i < commandArgs.Length; i++)
                {
                    starship.AddEnhancement(
                        enhancementFactory
                        .Create(CastStringToEnhancementType(commandArgs[i])));
                }
            }

            this.GameEngine.Starships.Add(starship);

            Console.WriteLine(Messages.CreatedShip, starshipType, starshipName);
        }

        private StarshipType CastStringToStarshipType(string shipType)
        {
            switch (shipType)
            {
                case "Frigate" : return StarshipType.Frigate;
                case "Cruiser": return StarshipType.Cruiser;
                case "Dreadnought": return StarshipType.Dreadnought;
                default:
                    throw new NotImplementedException();
            }
        }

        private EnhancementType CastStringToEnhancementType(string enhancementType)
        {
            switch (enhancementType)
            {
                case "ThanixCannon":
                    return EnhancementType.ThanixCannon;
                case "KineticBarrier":
                    return EnhancementType.KineticBarrier;
                case "ExtendedFuelCells":
                    return EnhancementType.ExtendedFuelCells;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
