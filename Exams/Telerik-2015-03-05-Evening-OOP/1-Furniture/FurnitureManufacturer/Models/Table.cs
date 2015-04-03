using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Models;

namespace FurnitureManufacturer.Engine.Factories
{
    public class Table : Furniture, ITable, IFurniture
    {
        private decimal lenght;
        private decimal width;
        public Table(string model, MaterialType material, decimal price, decimal height, decimal lenght, decimal width) 
            : base(model, material, price, height)
        {
            this.Length = lenght;
            this.Width = width;
        }

        public decimal Length
        {
            get
            {
                return this.lenght;
            }
            private set
            {
                Validator.NotNegativeNumber(value);
                this.lenght = value;
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                Validator.NotNegativeNumber(value);
                this.width = value;
            }
        }

        public decimal Area
        {
            get
            {
                return this.Width * this.Length;
            }
        }

        public override string ToString()
        {
            string str = string.Format(", Length: {0}, Width: {1}, Area: {2}"
                , this.Length, this.Width, this.Area).Trim();
            return base.ToString() + str;
        }
    }
}
