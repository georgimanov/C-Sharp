using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    using MassEffect.GameObjects.Locations;

    public class Cruiser : Starship
    {
        public Cruiser(string name, StarSystem location)
            : base(name, location, health: 100, shileds: 100, damage: 50, fuel: 300)
        {
            this.Type = StarshipType.Cruiser;
        }

        // Shoots a PenetrationShell with damage equal to its own damage.
        public override IProjectile ProduceAttack()
        {
            return new PenetrationShell(this.Damage);
        }
    }
}
