namespace MassEffect.GameObjects.Projectiles
{
    using MassEffect.Interfaces;

    class Laser : Projectile
    {
        public Laser(int damage)
            : base(damage)
        {
        }

        // Removes shields from the ship equal to the projectile's damage. 
        // If the damage is more than the ship's shields, it also takes health equal to the damage left. 
        // (e.g. 50 shields and 100 health - a laser of 80 damage would remove 50 shields and 30 health, 
        // resulting in 0 shields and 70 health for the ship).
        public override void Hit(IStarship ship)
        {
            var excessDamage = ship.Shields - this.Damage;

            if (excessDamage < 0)
            {
                ship.Shields = 0;
                ship.Health += excessDamage;
            }
            else
            {
                ship.Shields -= this.Damage;
            }
        }
    }
}
