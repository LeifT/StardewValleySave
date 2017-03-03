namespace StardewValleySave.Locations {
    public class CommunityCenter : GameLocation {
        public SerializableDictionary<int, bool[]> bundles;
        public SerializableDictionary<int, bool> bundleRewards;
        public bool[] areasComplete = new bool[6];
        public int numberOfStarsOnPlaque;
    }
}