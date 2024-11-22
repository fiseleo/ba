using FlatData;

namespace MX.GameLogic.DBModel
{
    public class CampaignChapterClearRewardHistoryDB
    {
        public long AccountServerId { get; set; }

        public long ChapterUniqueId { get; set; }

        public StageDifficulty RewardType { get; set; }

        public DateTime ReceiveDate { get; set; }

        public CampaignChapterClearRewardHistoryDB() { }
    }
}
