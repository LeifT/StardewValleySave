using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using StardewValleySave.Locations;

namespace StardewValleySave.Buildings {
    [XmlInclude(typeof(Barn))]
    [XmlInclude(typeof(Coop))]
    [XmlInclude(typeof(JunimoHut))]
    [XmlInclude(typeof(Mill))]
    [XmlInclude(typeof(Stable))]
    public class Building {
        public GameLocation indoors;
        public int tileX;
        public int tileY;
        public int tilesWide;
        public int tilesHigh;
        public int maxOccupants;
        public int currentOccupants;
        public int daysOfConstructionLeft;
        public int daysUntilUpgrade;
        public string buildingType;
        public string nameOfIndoors;
        public string baseNameOfIndoors;
        public string nameOfIndoorsWithoutUnique;
        public Point humanDoor;
        public Point animalDoor;
        public Color color;
        public bool animalDoorOpen;
        public bool magical;
        public long owner;
    }
}
