using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class InteractionManagerExtended : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            Item itemToBeCreated = null;
            switch (itemTypeString)
            {
                case "weapon":
                    itemToBeCreated = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    itemToBeCreated = new Wood(itemNameString, itemLocation);
                    break;
                default:
                    itemToBeCreated = base.CreateItem(itemTypeString, itemNameString, itemLocation, itemToBeCreated);
                    break;
            }

            return itemToBeCreated;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    location = base.CreateLocation(locationTypeString, locationName);
                    break;
            }

            return location;
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                
                default:
                    person = base.CreatePerson(personTypeString, personNameString, personLocation);
                    break;
            }

            return person;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather" :
                    this.HandleGatherInteraction(actor, commandWords[2]);
                    break;
                case "craft" :
                    this.HandleCraftInteraction(actor, commandWords[2], commandWords[3]);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }

        }

        private void HandleCraftInteraction(Person actor, string itemType, string itemName)
        {
            switch (itemType)
            {
                case "weapon":
                    this.HandleWeaponCrafting(actor, itemName);
                    break;
                case "armor":
                    this.HandleArmorCrafting(actor, itemName);
                    break;
                default: break;
            }
        }

        private void HandleWeaponCrafting(Person actor, string itemName)
        {
            if (actor.HasItemInInvetory(ItemType.Iron) && actor.HasItemInInvetory(ItemType.Wood))
            {
                this.AddToPerson(actor, new Weapon(itemName));
            }
        }

        private void HandleArmorCrafting(Person actor, string itemName)
        {
            if (actor.HasItemInInvetory(ItemType.Iron))
            {
                    this.AddToPerson(actor, new Armor(itemName));
            }
        }

        private void HandleGatherInteraction(Person actor, string itemName)
        {

            if (actor.Location is IGatheringLocation)
            {
                var gatheringLocation = actor.Location as IGatheringLocation;

                if (actor.HasItemInInvetory(gatheringLocation.RequiredItem))
                {
                    this.AddToPerson(actor, gatheringLocation.ProduceItem(itemName));
                }
            }
        }
    }
}
