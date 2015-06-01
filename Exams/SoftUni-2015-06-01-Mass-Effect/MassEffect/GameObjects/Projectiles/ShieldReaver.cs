namespace MassEffect.GameObjects.Projectiles
{
    using MassEffect.Interfaces;

    class ShieldReaver : Projectile
    {
        // Removes health from the ship equal to the projectile's damage. 
        // It also removes shields from the ship equal to 2x the projectile's damage
        public override void Hit(IStarship ship)
        {
            ship.Health -= this.Damage;
            ship.Shields -= 2*this.Damage;
        }

        public ShieldReaver(int damage) 
            : base(damage)
        {
        }
    }
}
