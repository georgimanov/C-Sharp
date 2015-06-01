namespace MassEffect.GameObjects.Ships
{
    using MassEffect.GameObjects.Locations;
    using MassEffect.GameObjects.Projectiles;
    using MassEffect.Interfaces;
    public class Dreadnought : Starship
    {
        public Dreadnought(string name, StarSystem location)
            : base(name, location, health: 200, shileds: 300, damage: 150, fuel: 700)
        {
            this.Type = StarshipType.Dreadnought;
            this.Attacked = true;
        }

        public bool Attacked { get; set; }
        // Shoots a Laser with damage equal to half its shields + own damage. 
        public override IProjectile ProduceAttack()
        {
            return new Laser( (this.Shields / 2) + this.Damage);
        }

        // Responds to an attack by raising its shields by 50 before the attack and removes them after it.
        public override void RespondToAttack(IProjectile attack)
        {
            if (this.Attacked)
            {
                this.Shields += 50;
                this.Attacked = false;
            }
            else
            {
                this.Shields -= 50;
                this.Attacked = true;

            }
        }
    }
}
