namespace Cosmetics.Products
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Cosmetics.Contracts;

    public class ShoppingCart : IShoppingCart
    {

        private ICollection<IProduct> products;

        public ShoppingCart()
        {
            this.products = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.products.Remove(product);
        }

        // TODO: Check equals?
        public bool ContainsProduct(IProduct product)
        {
            //return this.products.Any(p => p == product);
            return this.products.Any(p => p.Name == product.Name);
        }

        public decimal TotalPrice()
        {
            decimal sum = this.products.Sum(p => p.Price);

            return sum;
        }
    }
}
