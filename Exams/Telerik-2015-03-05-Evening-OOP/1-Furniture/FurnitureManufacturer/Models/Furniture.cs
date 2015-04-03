using System;
using System.Text;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Engine.Factories;

namespace FurnitureManufacturer.Models
{
    public abstract class Furniture : IFurniture
    {
        protected decimal height;
        protected string material;
        protected string model;
        protected decimal price;

        protected Furniture(string model, MaterialType material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material.ToString();
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            protected set
            {
                Validator.CheckNullOrEmpty(value);
                Validator.CheckLenght(value, 3, false);
                
                this.model = value;
            }
        }

        public string Material
        {
            get
            {
                return this.material;
            }
            protected set
            {
                this.material = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                Validator.NotNegativeNumber(value);
                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                Validator.NotNegativeNumber(value);
                this.height = value;
            }
        }

        public override string ToString()
        {

            string str = string.Format(
                "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name,
                this.Model, this.Material, this.Price, this.Height).Trim();
          
            return str;
        }
    }
}