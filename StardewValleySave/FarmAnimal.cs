using Microsoft.Xna.Framework;

namespace StardewValleySave {
    public class FarmAnimal : Character {
        public int defaultProduceIndex;
        public int deluxeProduceIndex;
        public int currentProduce;
        public int friendshipTowardFarmer;
        public int daysSinceLastFed;
        public int pushAccumulator;
        public int uniqueFrameAccumulator = -1;
        public int age;
        public int meatIndex;
        public int health;
        public int price;
        public int produceQuality;
        public byte daysToLay;
        public byte daysSinceLastLay;
        public byte ageWhenMature;
        public byte harvestType;
        public byte happiness;
        public byte fullness;
        public byte happinessDrain;
        public byte fullnessDrain;
        public bool wasPet;
        public bool showDifferentTextureWhenReadyForHarvest;
        public bool allowReproduction = true;
        public string sound;
        public string type;
        public string buildingTypeILiveIn;
        public string toolUsedForHarvest;
        public Rectangle frontBackBoundingBox;
        public Rectangle sidewaysBoundingBox;
        public Rectangle frontBackSourceRect;
        public Rectangle sidewaysSourceRect;
        public long myID;
        public long ownerID;
        public long parentId = -1;
        public Vector2 homeLocation;
        public short moodMessage;
    }
}
