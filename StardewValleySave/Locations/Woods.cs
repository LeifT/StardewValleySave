using System.Collections.Generic;
using StardewValleySave.TerrainFeatures;

namespace StardewValleySave.Locations {
    public class Woods : GameLocation {
        public List<ResourceClump> stumps = new List<ResourceClump>();
        public bool hasUnlockedStatue;
        public bool hasFoundStardrop;
    }
}