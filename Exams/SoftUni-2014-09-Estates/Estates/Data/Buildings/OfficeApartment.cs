namespace Estates.Data.Buildings
{
    using Estates.Interfaces;

    public abstract class OfficeApartment : Estate, IBuildingEstate
    {
        public int Rooms { get; set; }
        
        public bool HasElevator { get; set; }
        
        public override string ToString()
        {
            return base.ToString() + ", Rooms: " + this.Rooms + ", Elevator: " + (this.HasElevator ? "Yes" : "No");
        }
    }
}
