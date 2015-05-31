namespace Estates.Data.Buildings
{
    using Estates.Interfaces;

    public class Garage : Estate, IGarage
    {
        public Garage()
        {
            this.Type = EstateType.Garage;
        }
        
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
