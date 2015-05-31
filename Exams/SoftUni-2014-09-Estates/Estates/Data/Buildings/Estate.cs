using System.Text;

namespace Estates.Data.Buildings
{
    using Estates.Interfaces;

    public abstract class Estate : IEstate
    {
        public string Name { get; set; }
        public EstateType Type { get; set; }
        public double Area { get; set; }
        public string Location { get; set; }
        public bool IsFurnished { get; set; }

        public override string ToString()
        {
            var output =  string.Format("{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}", this.GetType().Name, this.Name, this.Area, this.Location, (this.IsFurnished ? "Yes" : "No"));
            
            return output;
        }
    }
}
