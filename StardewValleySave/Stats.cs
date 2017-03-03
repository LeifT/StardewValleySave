namespace StardewValleySave {
    public class Stats {
        public uint seedsSown;
        public uint itemsShipped;
        public uint itemsCooked;
        public uint itemsCrafted;
        public uint chickenEggsLayed;
        public uint duckEggsLayed;
        public uint cowMilkProduced;
        public uint goatMilkProduced;
        public uint rabbitWoolProduced;
        public uint sheepWoolProduced;
        public uint cheeseMade;
        public uint goatCheeseMade;
        public uint trufflesFound;
        public uint stoneGathered;
        public uint rocksCrushed;
        public uint dirtHoed;
        public uint giftsGiven;
        public uint timesUnconscious;
        public uint averageBedtime;
        public uint timesFished;
        public uint fishCaught;
        public uint bouldersCracked;
        public uint stumpsChopped;
        public uint stepsTaken;
        public uint monstersKilled;
        public uint diamondsFound;
        public uint prismaticShardsFound;
        public uint otherPreciousGemsFound;
        public uint caveCarrotsFound;
        public uint copperFound;
        public uint ironFound;
        public uint coalFound;
        public uint coinsFound;
        public uint goldFound;
        public uint iridiumFound;
        public uint barsSmelted;
        public uint beveragesMade;
        public uint preservesMade;
        public uint piecesOfTrashRecycled;
        public uint mysticStonesCrushed;
        public uint daysPlayed;
        public uint weedsEliminated;
        public uint sticksChopped;
        public uint notesFound;
        public uint questsCompleted;
        public uint starLevelCropsShipped;
        public uint cropsShipped;
        public uint slimesKilled;
        public uint geodesCracked;
        public SerializableDictionary<string, int> specificMonstersKilled = new SerializableDictionary<string, int>();

        public uint CropsShipped {
            get {
                return cropsShipped;
            }
            set {
                cropsShipped = value;
            }
        }

        public uint GeodesCracked {
            get {
                return geodesCracked;
            }
            set {
                geodesCracked = value;
            }
        }

        public uint SlimesKilled {
            get {
                return slimesKilled;
            }
            set {
                slimesKilled = value;
            }
        }

        public uint StarLevelCropsShipped {
            get {
                return starLevelCropsShipped;
            }
            set {
                starLevelCropsShipped = value;
            }
        }
        
        public uint StoneGathered {
            get {
                return stoneGathered;
            }
            set {
                stoneGathered = value;
            }
        }
        
        public uint QuestsCompleted {
            get {
                return questsCompleted;
            }
            set {
                questsCompleted = value;
            }
        }
        
        public uint FishCaught {
            get {
                return fishCaught;
            }
            set {
                fishCaught = value;
            }
        }
        
        public uint NotesFound {
            get {
                return notesFound;
            }
            set {
                notesFound = value;
            }
        }
        
        public uint SticksChopped {
            get {
                return sticksChopped;
            }
            set {
                sticksChopped = value;
            }
        }

        public uint WeedsEliminated {
            get {
                return weedsEliminated;
            }
            set {
                weedsEliminated = value;
            }
        }

        public uint DaysPlayed {
            get {
                return daysPlayed;
            }
            set {
                daysPlayed = value;
            }
        }

        public uint BouldersCracked {
            get {
                return bouldersCracked;
            }
            set {
                bouldersCracked = value;
            }
        }

        public uint MysticStonesCrushed {
            get {
                return mysticStonesCrushed;
            }
            set {
                mysticStonesCrushed = value;
            }
        }

        public uint GoatCheeseMade {
            get {
                return goatCheeseMade;
            }
            set {
                goatCheeseMade = value;
            }
        }

        public uint CheeseMade {
            get {
                return cheeseMade;
            }
            set {
                cheeseMade = value;
            }
        }

        public uint PiecesOfTrashRecycled {
            get {
                return piecesOfTrashRecycled;
            }
            set {
                piecesOfTrashRecycled = value;
            }
        }

        public uint PreservesMade {
            get {
                return preservesMade;
            }
            set {
                preservesMade = value;
            }
        }

        public uint BeveragesMade {
            get {
                return beveragesMade;
            }
            set {
                beveragesMade = value;
            }
        }

        public uint BarsSmelted {
            get {
                return barsSmelted;
            }
            set {
                barsSmelted = value;
            }
        }

        public uint IridiumFound {
            get {
                return iridiumFound;
            }
            set {
                iridiumFound = value;
            }
        }

        public uint GoldFound {
            get {
                return goldFound;
            }
            set {
                goldFound = value;
            }
        }

        public uint CoinsFound {
            get {
                return coinsFound;
            }
            set {
                coinsFound = value;
            }
        }
        
        public uint CoalFound {
            get {
                return coalFound;
            }
            set {
                coalFound = value;
            }
        }

        public uint IronFound {
            get {
                return ironFound;
            }
            set {
                ironFound = value;
            }
        }

        public uint CopperFound {
            get {
                return copperFound;
            }
            set {
                copperFound = value;
            }
        }

        public uint CaveCarrotsFound {
            get {
                return caveCarrotsFound;
            }
            set {
                caveCarrotsFound = value;
            }
        }

        public uint OtherPreciousGemsFound {
            get {
                return otherPreciousGemsFound;
            }
            set {
                otherPreciousGemsFound = value;
            }
        }

        public uint PrismaticShardsFound {
            get {
                return prismaticShardsFound;
            }
            set {
                prismaticShardsFound = value;
            }
        }

        public uint DiamondsFound {
            get {
                return diamondsFound;
            }
            set {
                diamondsFound = value;
            }
        }

        public uint MonstersKilled {
            get {
                return monstersKilled;
            }
            set {
                monstersKilled = value;
            }
        }

        public uint StepsTaken {
            get {
                return stepsTaken;
            }
            set {
                stepsTaken = value;
            }
        }

        public uint StumpsChopped {
            get {
                return stumpsChopped;
            }
            set {
                stumpsChopped = value;
            }
        }

        public uint TimesFished {
            get {
                return timesFished;
            }
            set {
                timesFished = value;
            }
        }
        
        public uint AverageBedtime {
            get {
                return averageBedtime;
            }
            set {
                averageBedtime = (averageBedtime * (daysPlayed - 1) + value) / daysPlayed;
            }
        }

        public uint TimesUnconscious {
            get {
                return timesUnconscious;
            }
            set {
                timesUnconscious = value;
            }
        }

        public uint GiftsGiven {
            get {
                return giftsGiven;
            }
            set {
                giftsGiven = value;
            }
        }

        public uint DirtHoed {
            get {
                return dirtHoed;
            }
            set {
                dirtHoed = value;
            }
        }

        public uint RocksCrushed {
            get {
                return rocksCrushed;
            }
            set {
                rocksCrushed = value;
            }
        }
        
        public uint TrufflesFound {
            get {
                return trufflesFound;
            }
            set {
                trufflesFound = value;
            }
        }

        public uint SheepWoolProduced {
            get {
                return sheepWoolProduced;
            }
            set {
                sheepWoolProduced = value;
            }
        }

        public uint RabbitWoolProduced {
            get {
                return rabbitWoolProduced;
            }
            set {
                rabbitWoolProduced = value;
            }
        }

        public uint GoatMilkProduced {
            get {
                return goatMilkProduced;
            }
            set {
                goatMilkProduced = value;
            }
        }

        public uint CowMilkProduced {
            get {
                return cowMilkProduced;
            }
            set {
                cowMilkProduced = value;
            }
        }

        public uint DuckEggsLayed {
            get {
                return duckEggsLayed;
            }
            set {
                duckEggsLayed = value;
            }
        }
        
        public uint ItemsCrafted{
            get{
                return itemsCrafted;
            }
            set{
                itemsCrafted = value;
            }
        }
        
        public uint ChickenEggsLayed {
            get {
                return chickenEggsLayed;
            }
            set {
                chickenEggsLayed = value;
            }
        }

        public uint ItemsCooked {
            get {
                return itemsCooked;
            }
            set {
                itemsCooked = value;
            }
        }

        public uint ItemsShipped {
            get {
                return itemsShipped;
            }
            set {
                itemsShipped = value;
            }
        }
        
        public uint SeedsSown {
            get {
                return seedsSown;
            }
            set {
                seedsSown = value;
            }
        }     
    }
}
