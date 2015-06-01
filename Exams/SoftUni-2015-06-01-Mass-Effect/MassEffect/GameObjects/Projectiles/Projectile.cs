namespace MassEffect.GameObjects.Projectiles
{
    using System;
    using MassEffect.Interfaces;

    public abstract class Projectile : IProjectile
    {
        protected Projectile(int damage)
        {
            this.Damage = damage;
        }

        public override int Damage { get; set; }

        public override void Hit(IStarship ship)
        {
            
        }
    }
}
