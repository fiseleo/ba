using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    public class MiniGameDreamMakerInfoDB
    {
        public long EventContentId { get; set; }

        public long Round { get; set; }

        public long Multiplier { get; set; }

        public long DayOfNumber { get; set; }

        public long ActionCount { get; set; }

        public long CurrentRoundEndingId { get; set; }

        public bool EndingRewardReceived { get; set; }

        public bool CanStartNewGame { get; set; }

        [JsonIgnore]
        public bool CanReceiveEndingReward
        {
            get { return default(bool); }
        }

        public MiniGameDreamMakerInfoDB() { }
    }
}
