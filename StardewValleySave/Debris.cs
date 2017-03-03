using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace StardewValleySave {
    public class Debris {
        public int chunkType;
        public int sizeOfSourceRectSquares;
        public int itemQuality;
        public int chunkFinalYLevel;
        public int chunkFinalYTarget;
        public float timeSinceDoneBouncing;
        public float scale;
        public bool itemDebris;
        public bool floppingFish;
        public bool isFishable;
        public bool movingFinalYLevel;
        public bool visible;
        public DebrisType debrisType;
        public string debrisMessage;
        public Color nonSpriteChunkColor;
        public Color chunksColor;
        public Item item;
        public int uniqueID;
        public Character toHover;

        private List<Chunk> chunks = new List<Chunk>();

        public List<Chunk> Chunks {
            get {
                return chunks;
            }
        }

        public enum DebrisType {
            CHUNKS,
            LETTERS,
            SQUARES,
            ARCHAEOLOGY,
            OBJECT,
            SPRITECHUNKS,
            RESOURCE,
            NUMBERS
        }
    }
}
