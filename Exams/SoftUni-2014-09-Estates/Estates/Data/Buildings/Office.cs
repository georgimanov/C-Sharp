namespace Estates.Data.Buildings
{
    using Estates.Interfaces;

    public class Office : OfficeApartment, IOffice
    {
        public Office()
        {
            this.Type = EstateType.Office;
        }
    }
}
