namespace MassEffect.GameObjects.Projectiles
{
    using System;
    using MassEffect.Interfaces;

    public class PenetrationShell : Projectile
    {
        public PenetrationShell(int damage)
            : base(damage)
        {
        }

        // Removes health from the ship equal to the projectile's damage.
        public override void Hit(IStarship ship)
        {
            ship.Health -= this.Damage;
        }
    }
}
