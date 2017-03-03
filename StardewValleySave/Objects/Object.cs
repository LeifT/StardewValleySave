using System.Xml.Serialization;
using Microsoft.Xna.Framework;

namespace StardewValleySave.Objects {
    [XmlInclude(typeof(Fence))]
    [XmlInclude(typeof(Boots))]
    [XmlInclude(typeof(Cask))]
    [XmlInclude(typeof(Chest))]
    [XmlInclude(typeof(ColoredObject))]
    [XmlInclude(typeof(CrabPot))]
    [XmlInclude(typeof(Door))]
    [XmlInclude(typeof(Hat))]
    [XmlInclude(typeof(Ring))]
    [XmlInclude(typeof(SpecialItem))]
    [XmlInclude(typeof(SwitchFloor))]
    [XmlInclude(typeof(TV))]
    [XmlInclude(typeof(Wallpaper))]
    [XmlInclude(typeof(WickedStatue))]
    [XmlInclude(typeof(Torch))]
    public class Object : Item {
        public Vector2 tileLocation;
        public int parentSheetIndex;
        public long owner;
        public string name;
        public string type;
        public bool canBeSetDown;
        public bool canBeGrabbed;
        public bool isHoedirt;
        public bool isSpawnedObject;
        public bool questItem;
        public bool isOn;
        public int fragility;
        public int price;
        public int edibility;
        public int stack;
        public int quality;
        public bool bigCraftable;
        public bool setOutdoors;
        public bool setIndoors;
        public bool readyForHarvest;
        public bool showNextIndex;
        public bool flipped;
        public bool hasBeenPickedUpByFarmer;
        public bool isRecipe;
        public bool isLamp;
        public Object heldObject;
        public int minutesUntilReady;
        public Rectangle boundingBox;
        public Vector2 scale;
    }
}
