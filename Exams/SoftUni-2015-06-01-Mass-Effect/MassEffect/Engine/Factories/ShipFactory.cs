namespace MassEffect.Engine.Factories
{
    using System;

    using MassEffect.GameObjects.Locations;
    using MassEffect.GameObjects.Ships;
    using MassEffect.Interfaces;

    public class ShipFactory
    {
        public IStarship CreateShip(StarshipType type, string name, StarSystem location)
        {
            switch (type)
            {
                case StarshipType.Frigate:
                    return new Frigate(name, location);
                case StarshipType.Cruiser:
                    return new Cruiser(name, location);
                case StarshipType.Dreadnought:
                    return new Dreadnought(name, location);
                default:
                    throw new NotSupportedException("Starship type not supported.");
            }
        }
    }
}
