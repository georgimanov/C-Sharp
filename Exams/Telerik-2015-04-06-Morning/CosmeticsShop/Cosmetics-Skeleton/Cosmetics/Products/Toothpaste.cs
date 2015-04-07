namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Toothpaste : Product, IToothpaste
    {
        protected IList<string> ingredients;
        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ingredients = new List<string>(ingredients);
        }

        public string Ingredients
        {
            get { return string.Join(", ", this.ingredients); }
        }

        public override string Print()
        {
            string print = string.Format(Environment.NewLine +
                "  * Ingredients: {0}", this.Ingredients);

            return base.Print() + print;
        }
    }
}
