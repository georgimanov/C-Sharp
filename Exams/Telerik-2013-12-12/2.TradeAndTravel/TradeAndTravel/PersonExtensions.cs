using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public static class PersonExtensions
    {

        public static bool HasItemInInvetory(this Person actor, ItemType itemType)
        {
            return actor.ListInventory().Any(i => i.ItemType == itemType);
        }
    }
}
