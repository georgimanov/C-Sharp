namespace MassEffect.GameObjects.Enhancements
{
    public class ThanixCannon : Enhancement
    {
        public ThanixCannon() : 
            base(EnhancementType.ThanixCannon.ToString(), shieldBonus: 0, damageBonus: 50, fuelBonus: 0)
        {
        }
    }
}
