using System.Collections.Generic;
using StardewValleySave.Buildings;

namespace StardewValleySave.Locations {
    public class BuildableGameLocation : GameLocation {
        public List<Building> buildings = new List<Building>();
    }
}
