using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Models;

namespace FurnitureManufacturer.Models
{
    public class Chair : Furniture, IChair, IFurniture
    {
        private int numberOfLegs;

        public Chair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            set
            {
                this.numberOfLegs = value;
                
            }
        }

        public override string ToString()
        {
            string str = string.Format(", Legs: {0}", this.NumberOfLegs).Trim();
            return base.ToString() + str;
        }
    }
}
