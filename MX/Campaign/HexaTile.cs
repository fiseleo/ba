using Newtonsoft.Json;

namespace MX.Campaign
{
    [Serializable]
    public class HexaTile
    {
        public bool PlayAnimation { get; set; }

        [JsonIgnore]
        public bool IsBattleReady
        {
            get { return default(bool); }
        }

        [JsonIgnore]
        public bool StartTile
        {
            get { return default(bool); }
        }

        public HexaTile() { }

        public HexaTile(HexaTile tile) { }

        public HexaTile Clone()
        {
            return null;
        }

        public bool IsValidTile()
        {
            return default(bool);
        }

        public HexaTileState ExtractTileState()
        {
            return null;
        }

        public string ResourcePath;

        public bool IsHide;

        public bool IsFog;

        public bool CanNotMove;

        public HexLocation Location;

        public Strategy Strategy;

        public HexaUnit Unit;

        [JsonIgnore]
        public HexaUnit ChallengeUnit;
    }
}
