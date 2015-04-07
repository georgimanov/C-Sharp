using Cosmetics.Common;

namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Cosmetics.Contracts;

    public class Category : ICategory
    {
        protected string name;
        protected ICollection<IProduct> cosmeticsList;

        public Category(string name)
        {
            this.Name = name;
            this.cosmeticsList = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                Validator.CheckIfNull(value, "Category name cannot be null or empty");
                Validator.CheckIfStringLengthIsValid(value,15,2,"Category name must be between 2 and 15 symbols long!");
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.cosmeticsList.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (this.cosmeticsList.All(c => c.Name != cosmetics.Name))
            {
                string message = string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.name);
                throw new ArgumentNullException(message);
            }

            this.cosmeticsList.Remove(cosmetics);
        }

        public string Print()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("{0} category - {1} {2} in total", this.Name,
                this.cosmeticsList.Count, (this.cosmeticsList.Count == 1 ? "product" : "products")));
            
            foreach (var cosmetics in this.cosmeticsList.OrderBy(brand=> brand.Brand).ThenByDescending(price => price.Price))
            {
                result.AppendLine(cosmetics.Print());
            }

            return result.ToString().TrimEnd();
        }
    }
}
