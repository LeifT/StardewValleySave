using System.Collections.Generic;
using StardewValleySave.TerrainFeatures;

namespace StardewValleySave.Locations {
    public class MineShaft : GameLocation {
        public SerializableDictionary<int, MineInfo> permanentMineChanges;
        public List<ResourceClump> resourceClumps = new List<ResourceClump>();
        public int mineLevel;
        public int nextLevel;
        public int lowestLevelReached;
    }
}
