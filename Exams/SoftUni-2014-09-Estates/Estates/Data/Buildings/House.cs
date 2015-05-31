namespace Estates.Data.Buildings
{
    using Estates.Interfaces;

    public class House : Estate, IHouse
    {
        public House()
        {
            this.Type = EstateType.House;
        }
        
        public int Floors { get; set; }
    }
}
