using StardewValleySave.Characters;

namespace StardewValleySave {
    public class SaveGameInfo {
        public SaveGameInfo(Farmer farmer, string saveFile) {
            Farmer = farmer;
            SaveFile = saveFile;
        }
        public Farmer Farmer;
        public string SaveFile;
    }
}
