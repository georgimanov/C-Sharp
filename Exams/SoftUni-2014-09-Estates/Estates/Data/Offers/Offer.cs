using System;
using System.Collections;
using System.Collections.Generic;
using Estates.Interfaces;

namespace Estates.Data.Offers
{
    public abstract class Offer : IOffer
    {
        protected decimal price;
        
        public OfferType Type { get; set; }
        public IEstate Estate { get; set; }

        public override string ToString()
        {
            string ouput = String.Format("{0}: Estate = {1}, Location = {2}, Price = {3}", this.GetType().Name.Substring(0, 4), this.Estate.Name, this.Estate.Location, this.price);

            return ouput;
        }
    }
}
