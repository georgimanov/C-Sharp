using System;
using System.Text;
using MassEffect.GameObjects.Projectiles;
using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Ships
{
    using MassEffect.GameObjects.Locations;

    public class Frigate : Starship
    {
        public Frigate(string name, StarSystem location) 
            : base(name, location, health: 60, shileds: 50, damage: 30, fuel: 220)
        {
            this.ProjectilesFired = 0;
            this.Type = StarshipType.Frigate;
        }

        public int ProjectilesFired { get; set; }

        // Shoots a ShieldReaver with damage equal to its own damage.
        public override IProjectile ProduceAttack()
        {
            this.ProjectilesFired++;

            return new ShieldReaver(this.Damage);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();

            if (this.Health > 0)
            {
                sb.AppendLine(String.Format("-Projectiles fired: {0}", this.ProjectilesFired));
            }

            return base.ToString() + sb.ToString().TrimEnd();
        }
    }
}
