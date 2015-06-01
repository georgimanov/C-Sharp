namespace MassEffect.GameObjects.Enhancements
{
    public class KineticBarrier : Enhancement
    {
        public KineticBarrier() 
            : base(name: EnhancementType.KineticBarrier.ToString(), shieldBonus: 100, damageBonus: 0, fuelBonus: 0)
        {
        }
    }
}
