using System.Xml.Serialization;
using Object = StardewValleySave.Objects.Object;

namespace StardewValleySave.Tools {
    [XmlInclude(typeof(Axe))]
    [XmlInclude(typeof(FishingRod))]
    [XmlInclude(typeof(Hoe))]
    [XmlInclude(typeof(MagnifyingGlass))]
    [XmlInclude(typeof(MeleeWeapon))]
    [XmlInclude(typeof(MilkPail))]
    [XmlInclude(typeof(Pan))]
    [XmlInclude(typeof(Pickaxe))]
    [XmlInclude(typeof(Shears))]
    [XmlInclude(typeof(Slingshot))]
    [XmlInclude(typeof(Wand))]
    [XmlInclude(typeof(WateringCan))]
    public class Tool : Item {
        public string name;
        public string description;
        public int initialParentTileIndex;
        public int currentParentTileIndex;
        public int indexOfMenuItemView;
        public bool stackable;
        public bool instantUse;
        public int upgradeLevel;
        public int numAttachmentSlots;
        public Object[] attachments;

        public int CurrentParentTileIndex {
            get {
                return currentParentTileIndex;
            }
            set {
                currentParentTileIndex = value;
            }
        }

        public int UpgradeLevel {
            get {
                return upgradeLevel;
            }
            set {
                upgradeLevel = value;
            }
        }
    }
}
