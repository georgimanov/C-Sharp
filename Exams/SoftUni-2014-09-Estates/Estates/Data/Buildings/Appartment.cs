namespace Estates.Data.Buildings
{
    using Estates.Interfaces;

    public class Appartment : OfficeApartment, IApartment
    {
        public Appartment()
        {
            this.Type = EstateType.Apartment;
        }
    }
}
