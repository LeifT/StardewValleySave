using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace StardewValleySave {
    public class Crop {
        public List<int> phaseDays = new List<int>();
        public int rowInSpriteSheet;
        public int phaseToShow;
        public int currentPhase;
        public int harvestMethod;
        public int indexOfHarvest;
        public int regrowAfterHarvest;
        public int dayOfCurrentPhase;
        public int minHarvest;
        public int maxHarvest;
        public int maxHarvestIncreasePerFarmingLevel;
        public int daysOfUnclutteredGrowth;
        public int whichForageCrop;
        public List<string> seasonsToGrowIn = new List<string>();
        public Color tintColor;
        public bool flip;
        public bool fullyGrown;
        public bool raisedSeeds;
        public bool programColored;
        public bool dead;
        public bool forageCrop;
        public double chanceForExtraCrops;
    }
}
