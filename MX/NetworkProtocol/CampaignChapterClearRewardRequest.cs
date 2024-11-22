using FlatData;

namespace MX.NetworkProtocol
{
    public class CampaignChapterClearRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_ChapterClearReward; }
        }

        public long CampaignChapterUniqueId { get; set; }

        public StageDifficulty StageDifficulty { get; set; }

        public CampaignChapterClearRewardRequest() { }
    }
}
