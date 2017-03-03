using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewValleySave.Locations;

namespace StardewValleySave {
    public class AnimalHouse : GameLocation {
        public SerializableDictionary<long, FarmAnimal> animals = new SerializableDictionary<long, FarmAnimal>();
        public int animalLimit;
        public List<long> animalsThatLiveHere = new List<long>();
        public Point incubatingEgg;
    }
}
