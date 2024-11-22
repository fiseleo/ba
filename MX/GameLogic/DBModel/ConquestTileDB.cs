using FlatData;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class ConquestTileDB
    {
        public long EventContentId { get; set; }

        public StageDifficulty Difficulty { get; set; }

        public long TileUniqueId { get; set; }

        public TileState TileState { get; set; }

        public long Level { get; set; }

        public bool[] StarFlags { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsThreeStarClear
        {
            get { return default(bool); }
        }

        public bool IsAnyStarClear
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public long BestStarRecord
        {
            get { return 0L; }
        }

        public ConquestTileDB() { }

        public void CopyFrom(ConquestTileDB other) { }

        public ConquestTileDB Clone()
        {
            return null;
        }
    }
}
