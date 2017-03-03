using System.Collections.Generic;

namespace StardewValleySave.Locations {
    public class SeedShop : GameLocation {
        public List<Item> itemsFromPlayerToSell = new List<Item>();
        public List<Item> itemsToStartSellingTomorrow = new List<Item>();
    }
}
