namespace Estates.Data
{
    using System.Linq;

    using Estates.Engine;
    using Estates.Interfaces;

    public class ExtendsEstateEngine : EstateEngine
    {
        public override string ExecuteCommand(string cmdName, string[] cmdArgs)
        {
            switch (cmdName)
            {
                case "find-rents-by-location":
                    return this.ExecuteFindRentsByLocationCommand(cmdArgs[0]);
                case "find-rents-by-price":
                    return this.ExecuteFindRentsByPrice(cmdArgs[0], cmdArgs[1]);

                default:
                    return base.ExecuteCommand(cmdName, cmdArgs);
            }
        }

        private string ExecuteFindRentsByLocationCommand(string location)
        {
            var offers = this.Offers
                .Where(o => o.Estate.Location == location && o.Type == OfferType.Rent)
                .OrderBy(o => o.Estate.Name);

            return FormatQueryResults(offers);
        }

        private string ExecuteFindRentsByPrice(string minPrice, string maxPrice)
        {
            var offers = this.Offers
                .Where(o => o.Type == OfferType.Rent)
                .Cast<IRentOffer>()
                .Where(o => o.PricePerMonth >= decimal.Parse(minPrice) && o.PricePerMonth <= decimal.Parse(maxPrice))
                .OrderBy(o => o.PricePerMonth)
                .ThenBy(o => o.Estate.Name);

            return FormatQueryResults(offers);
        }
    }
}
