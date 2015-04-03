using System.Collections.Generic;
using System.Linq;
using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class Company : ICompany
    {
        public ICollection<IFurniture> catalog;
        public string name;
        public string registrationNumber;

        public Company(string name, string registrationNumber)
        {
            Name = name;
            RegistrationNumber = registrationNumber;
            catalog = new List<IFurniture>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                Validator.CheckNullOrEmpty(value);
                Validator.CheckLenght(value, 5, false);
                name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            set
            {
                Validator.CheckLenght(value, 10, true);
                Validator.DigitsOnly(value);

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return new List<IFurniture>(catalog.OrderBy(p => p.Price).ThenBy(m => m.Model)); }
        }

        public void Add(IFurniture furniture)
        {
            catalog.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            catalog.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return catalog.FirstOrDefault(m => m.Model == model);
        }

        public string Catalog()
        {
            var sb = new StringBuilder();
            var str = string.Format("{0} - {1} - {2} {3}",
                Name,
                RegistrationNumber,
                Furnitures.Count != 0 ? Furnitures.Count.ToString() : "no",
                Furnitures.Count != 1 ? "furnitures" : "furniture");
            sb.AppendLine(str);

            if (Furnitures.Count != 0)
            {
                foreach (var item in Furnitures)
                {
                    sb.AppendLine(item.ToString());
                }
            }

            return sb.ToString().Trim();
        }
    }
}