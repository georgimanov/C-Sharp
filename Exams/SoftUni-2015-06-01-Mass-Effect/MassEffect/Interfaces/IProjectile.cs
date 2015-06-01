namespace MassEffect.Interfaces
{
    public abstract class IProjectile
    {
        public abstract int Damage { get; set; }
        public abstract void Hit(IStarship ship);
    }
}
