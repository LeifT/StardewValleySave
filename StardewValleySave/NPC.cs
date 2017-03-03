using Microsoft.Xna.Framework;

namespace StardewValleySave {
    public class NPC : Character {
        public string defaultMap;
        public string loveInterest;
        public string birthday_Season;
        public int age;
        public int manners;
        public int socialAnxiety;
        public int optimism;
        public int gender;
        public int id;
        public int homeRegion;
        public int daysUntilBirthing;
        public int daysAfterLastBirth;
        public int birthday_Day;
        public int moveTowardPlayerThreshold;
        public bool isInvisible;
        public bool followSchedule = true;
        public bool datable;
        public bool datingFarmer;
        public bool divorcedFromFarmer;
        public int daysMarried;
        
        public int DefaultFacingDirection { get; set; }

        public string DefaultMap {
            get {
                return defaultMap;
            }
            set {
                defaultMap = value;
            } 
        }

        public Vector2 DefaultPosition { get; set; }
        public bool IsWalkingInSquare { get; set; }
        public bool IsWalkingTowardPlayer { get; set; }

        public virtual bool IsMonster {
            get {
                return false;
            }
        }
    }
}
