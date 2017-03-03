using System.Collections.Generic;
using System.Xml.Serialization;

namespace StardewValleySave.Quests {
    [XmlInclude(typeof(CraftingQuest))]
    [XmlInclude(typeof(FishingQuest))]
    [XmlInclude(typeof(GoSomewhereQuest))]
    [XmlInclude(typeof(ItemDeliveryQuest))]
    [XmlInclude(typeof(ItemHarvestQuest))]
    [XmlInclude(typeof(LostItemQuest))]
    [XmlInclude(typeof(ResourceCollectionQuest))]
    [XmlInclude(typeof(SlayMonsterQuest))]
    [XmlInclude(typeof(SocializeQuest))]
    public class Quest {
        public string currentObjective = "";
        public string questDescription = "";
        public string questTitle = "";
        public string rewardDescription;
        public string completionString;
        public bool accepted;
        public bool completed;
        public bool dailyQuest;
        public bool showNew;
        public bool canBeCancelled;
        public bool destroy;
        public int id;
        public int moneyReward;
        public int questType;
        public int daysLeft;
        public List<int> nextQuests = new List<int>();
    }
}