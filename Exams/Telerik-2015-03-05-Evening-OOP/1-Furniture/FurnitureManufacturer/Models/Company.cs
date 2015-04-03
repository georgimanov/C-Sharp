using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class Company : ICompany
    {
        public ICollection<IFurniture> furnitures;
        public string name;
        public string registrationNumber;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                Validator.CheckNullOrEmpty(value);
                Validator.CheckLenght(value, 5, false);
                this.name = value;
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

                if (value == null || value.Length != 10)
                {
                    throw new ArgumentNullException("Reg number cannot be null!");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {

            get { return this.furnitures; }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return furnitures.FirstOrDefault(m => m.Model.ToLower() == model.ToLower());
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
                var furniture = this.furnitures.OrderBy(p => p.Price).ThenBy(m => m.Model);

                foreach (var f in furniture)
                {
                    sb.AppendLine(f.ToString());
                }
            }

            return sb.ToString().Trim();
        }
    }
}