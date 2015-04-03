using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted = false;
        private const decimal convertedHeight = 0.10m;

        public ConvertibleChair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.IsConverted = isConverted;
        }

        public bool IsConverted
        {
            get { return this.isConverted; }
            private set { this.isConverted = value; }
        }

        public void Convert()
        {
            this.isConverted = !this.isConverted;
        }

        public override decimal Height
        {
            get
            {
                if (this.isConverted)
                {
                    return convertedHeight;
                }
                else
                {
                    return base.Height;
                }
            }
        }

        public override string ToString()
        {
            string str = string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal").Trim();
            return base.ToString() + str;
        }
    }
}
