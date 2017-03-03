using System.Xml.Serialization;
using StardewValleySave.Objects;
using StardewValleySave.Tools;

namespace StardewValleySave {
    [XmlInclude(typeof(Object))]
    [XmlInclude(typeof(Tool))]
    public abstract class Item {
        public int specialVariable;
        public int category;
        public bool specialItem;
        public bool hasBeenInInventory;

        public string Name { get; set; }
        public int Stack { get; set; }
    }
}
