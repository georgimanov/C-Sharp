using Estates.Engine;
using Estates.Interfaces;
using System;
using Estates.Data.Buildings;
using Estates.Data.Offers;

namespace Estates.Data
{
    public class EstateFactory
    {
        public static IEstateEngine CreateEstateEngine()
        {
            return new EstateEngine();
        }

        public static IEstate CreateEstate(EstateType type)
        {
            switch (type)
            {
                case EstateType.Apartment: return new Appartment();
                case EstateType.Garage: return new Garage();
                case EstateType.House: return new House();
                case EstateType.Office: return new Office();
                default:
                    throw new Exception();
            }
        }

        public static IOffer CreateOffer(OfferType type)
        {
            switch (type)
            {
                    case OfferType.Rent: return new RentOffer();
                    case OfferType.Sale: return new SaleOffer();
                default: 
                    throw new Exception();
            }
        }
    }
}
