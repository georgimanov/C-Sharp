namespace MassEffect.GameObjects.Enhancements
{
    public class ExtendedFuelCells : Enhancement
    {
        public ExtendedFuelCells() 
            : base(name: EnhancementType.ExtendedFuelCells.ToString(), shieldBonus: 0, damageBonus: 0, fuelBonus: 200)
        {
        }
    }
}
