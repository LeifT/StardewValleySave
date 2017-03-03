using System.Collections.Generic;

namespace StardewValleySave.Monsters {
    public class Monster : NPC {
        public int damageToFarmer;
        public int health;
        public int maxHealth;
        public int coinsToDrop;
        public int durationOfRandomMovements;
        public int resilience;
        public int slipperiness;
        public int experienceGained;
        public double jitteriness;
        public double missChance;
        public bool isGlider;
        public bool mineMonster;
        public bool hasSpecialItem;
        public List<int> objectsToDrop = new List<int>();

        public override bool IsMonster {
            get {
                return true;
            }
        }
    }
}
