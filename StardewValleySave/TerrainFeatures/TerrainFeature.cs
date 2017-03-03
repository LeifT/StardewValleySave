using System.Xml.Serialization;

namespace StardewValleySave.TerrainFeatures {
    [XmlInclude(typeof(Bush))]
    [XmlInclude(typeof(CosmeticPlant))]
    [XmlInclude(typeof(Flooring))]
    [XmlInclude(typeof(FruitTree))]
    [XmlInclude(typeof(GiantCrop))]
    [XmlInclude(typeof(Grass))]
    [XmlInclude(typeof(HoeDirt))]
    [XmlInclude(typeof(Quartz))]
    [XmlInclude(typeof(ResourceClump))]
    [XmlInclude(typeof(Stalagmite))]
    [XmlInclude(typeof(Tree))]
    public abstract class TerrainFeature { }
}
