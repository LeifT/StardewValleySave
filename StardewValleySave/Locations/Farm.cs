using System.Collections.Generic;
using System.Xml.Serialization;
using StardewValleySave.TerrainFeatures;

namespace StardewValleySave.Locations {
    [XmlRoot(nameof(Farm))]
    public class Farm : BuildableGameLocation {
        public SerializableDictionary<long, FarmAnimal> animals = new SerializableDictionary<long, FarmAnimal>();
        public List<ResourceClump> resourceClumps = new List<ResourceClump>();
        public int piecesOfHay;
        public int grandpaScore;
        public bool hasSeenGrandpaNote;
    }
}