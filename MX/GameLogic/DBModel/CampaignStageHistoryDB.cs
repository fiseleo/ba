using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace MX.GameLogic.DBModel
{
    [PrimaryKey(
        nameof(AccountServerId),
        nameof(StoryUniqueId),
        nameof(ChapterUniqueId),
        nameof(StageUniqueId)
    )]
    public class CampaignStageHistoryDB
    {
        public long AccountServerId { get; set; }

        public long StoryUniqueId { get; set; }

        public long ChapterUniqueId { get; set; }

        public long StageUniqueId { get; set; }

        public long TacticClearCountWithRankSRecord { get; set; }

        public long ClearTurnRecord { get; set; }

        [JsonIgnore]
        public long BestStarRecord
        {
            get { return 0L; }
        }

        public bool Star1Flag { get; set; }

        public bool Star2Flag { get; set; }

        public bool Star3Flag { get; set; }

        public DateTime LastPlay { get; set; }

        public long TodayPlayCount { get; set; }

        public long TodayPurchasePlayCountHardStage { get; set; }

        public DateTime? FirstClearRewardReceive { get; set; }

        public DateTime? StarRewardReceive { get; set; }

        [JsonIgnore]
        public bool IsClearedEver
        {
            get { return default(bool); }
        }

        public long TodayPlayCountForUI
        {
            get { return 0L; }
        }

        public bool GetStarFlag(int index)
        {
            return default(bool);
        }

        public CampaignStageHistoryDB() { }
    }
}
