using System.Collections.Generic;
using StardewValleySave.Objects;

namespace StardewValleySave.Locations {
    public class DecoratableLocation : GameLocation {
        public List<int> wallPaper = new List<int>();
        public List<int> floor = new List<int>();
        public List<Furniture> furniture = new List<Furniture>();
    }
}
