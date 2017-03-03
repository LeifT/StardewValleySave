using Microsoft.Xna.Framework;

namespace StardewValleySave {
    public class Character {
        public string name;
        public bool isEmoting;
        public bool isCharging;
        public bool willDestroyObjectsUnderfoot = true;
        public bool isGlowing;
        public bool coloredBorder;
        public bool flip;
        public bool drawOnTop;
        public bool faceTowardFarmer;
        public bool faceAwayFromFarmer;
        public bool ignoreMovementAnimation;
        public float scale;
        public float timeBeforeAIMovementAgain;
        public float glowingTransparency;
        public float glowRate;

        public Vector2 Position { get; set; }

        public int Speed { get; set; }

        public bool IsEmoting {
            get {
                return isEmoting;
            }
            set {
                isEmoting = value;
            }
        }

        public int CurrentEmote { get; set; }
    }
}