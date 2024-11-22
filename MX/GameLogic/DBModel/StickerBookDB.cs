using System.Collections.Generic;

namespace MX.GameLogic.DBModel
{
    public class StickerBookDB
    {
        public long AccountId { get; set; }

        public IEnumerable<StickerDB> UnusedStickerDBs { get; set; }

        public IEnumerable<StickerDB> UsedStickerDBs { get; set; }

        public StickerBookDB() { }
    }
}
