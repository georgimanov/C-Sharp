
namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Extended.Specialties;

    public class WolfRaider : Creature
    {
        public WolfRaider() 
            : base(8, 5, 10, (decimal)3.5)
        {
            this.AddSpecialty(new DoubleDamage(7));
        }
    }
}
