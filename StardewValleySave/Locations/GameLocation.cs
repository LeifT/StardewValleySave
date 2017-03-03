using System.Collections.Generic;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;
using StardewValleySave.TerrainFeatures;
using Object = StardewValleySave.Objects.Object;

namespace StardewValleySave.Locations {
    [XmlInclude(typeof(AnimalHouse))]
    [XmlInclude(typeof(Farm))]
    [XmlInclude(typeof(AdventureGuild))]
    [XmlInclude(typeof(BathHousePool))]
    [XmlInclude(typeof(Beach))]
    [XmlInclude(typeof(BusStop))]
    [XmlInclude(typeof(Cellar))]
    [XmlInclude(typeof(Club))]
    [XmlInclude(typeof(CommunityCenter))]
    [XmlInclude(typeof(Desert))]
    [XmlInclude(typeof(FarmCave))]
    [XmlInclude(typeof(FarmHouse))]
    [XmlInclude(typeof(Forest))]
    [XmlInclude(typeof(JojaMart))]
    [XmlInclude(typeof(LibraryMuseum))]
    [XmlInclude(typeof(MineShaft))]
    [XmlInclude(typeof(Mountain))]
    [XmlInclude(typeof(Railroad))]
    [XmlInclude(typeof(SeedShop))]
    [XmlInclude(typeof(Sewer))]
    [XmlInclude(typeof(Summit))]
    [XmlInclude(typeof(Town))]
    [XmlInclude(typeof(WizardHouse))]
    [XmlInclude(typeof(Woods))]
    [XmlInclude(typeof(Shed))]
    [XmlInclude(typeof(SlimeHutch))]
    public class GameLocation {
        public List<NPC> characters = new List<NPC>();
        public SerializableDictionary<Vector2, Object> objects = new SerializableDictionary<Vector2, Object>();
        public List<LargeTerrainFeature> largeTerrainFeatures;
        public SerializableDictionary<Vector2, TerrainFeature> terrainFeatures = new SerializableDictionary<Vector2, TerrainFeature>();
        public List<Debris> debris = new List<Debris>();
        public string name;
        public Color waterColor;
        public bool isFarm;
        public bool isOutdoors;
        public bool isStructure;
        public bool ignoreDebrisWeather;
        public bool ignoreOutdoorLighting;
        public bool ignoreLights;
        public bool treatAsOutdoors;
        public int numberOfSpawnedObjectsOnMap;
    }
}
