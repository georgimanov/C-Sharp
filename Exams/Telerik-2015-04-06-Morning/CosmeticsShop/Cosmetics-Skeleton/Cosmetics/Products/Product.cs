namespace Cosmetics.Products
{
    using System;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public abstract class Product : IProduct
    {
        protected string name;
        protected string brand;
        protected decimal price;
        protected GenderType gender;

        protected Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                Validator.CheckIfNull(value);
                Validator.CheckIfStringLengthIsValid(value, 10, 3, "Product name must be between 3 and 10 symbols long!");
                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }
            protected set
            {
                Validator.CheckIfNull(value);
                Validator.CheckIfStringLengthIsValid(value, 10, 2, "Product brand must be between 2 and 10 symbols long!");
                this.brand = value;
            }
        }

        public virtual decimal Price
        {
            get { return this.price; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Product price cannot be negative value!");
                }

                this.price = value;
            }
        }

        public Common.GenderType Gender
        {
            get { return this.gender; }
            protected set { this.gender = value; }
        }

        public virtual string Print()
        {
            string print = string.Format(
                "- {0} - {1}:" + Environment.NewLine +
                "  * Price: ${2}" + Environment.NewLine +
                "  * For gender: {3}", this.Brand, this.Name, this.Price, this.Gender);

            return print;
        }
    }
}
