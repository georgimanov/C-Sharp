using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class ConvertibleChair : Chair, IConvertibleChair, IChair, IFurniture
    {
        private bool isConverted;
        private const decimal convertedHeight = 0.10m;
        private readonly decimal initialHeight;

        public ConvertibleChair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs, bool isConverted = false)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.IsConverted = isConverted;
            initialHeight = height;
        }

        public bool IsConverted
        {
            get { return this.isConverted; }
            private set { this.isConverted = value; }
        }

        public void Convert()
        {
            this.isConverted = !this.isConverted;
            if (this.isConverted)
            {
                this.Height = convertedHeight;
            }
            else
            {
                this.Height = initialHeight;
            }
        }

        public override string ToString()
        {
            string str = string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal").Trim();
            return base.ToString() + str;
        }
    }
}
