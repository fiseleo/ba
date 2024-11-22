using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CampaignChapterClearRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_ChapterClearReward; }
        }

        public CampaignChapterClearRewardHistoryDB CampaignChapterClearRewardHistoryDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CampaignChapterClearRewardResponse() { }
    }
}
