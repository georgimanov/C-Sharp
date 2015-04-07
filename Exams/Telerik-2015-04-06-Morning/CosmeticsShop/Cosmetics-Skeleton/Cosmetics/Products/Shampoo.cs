using System;

namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    class Shampoo : Product, IShampoo
    {
        protected uint milliliters;
        protected UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public override decimal Price
        {
            get { return this.Milliliters * this.price; }
        }

        public uint Milliliters
        {
            get { return this.milliliters; }
            protected set { this.milliliters = value; }
        }

        public UsageType Usage
        {
            get { return this.usage; }
            protected set { this.usage = value; }
        }

        public override string Print()
        {
            string print = string.Format(Environment.NewLine +
                "  * Quantity: {0} ml" + Environment.NewLine +
                "  * Usage: {1}", this.Milliliters, this.Usage);

            return base.Print() + print;
        }
    }
}
