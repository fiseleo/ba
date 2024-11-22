using System.Collections.Generic;
using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CampaignTutorialStageResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_TutorialStageResult; }
        }

        public CampaignStageHistoryDB CampaignStageHistoryDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public List<ParcelInfo> ClearReward { get; set; }

        public List<ParcelInfo> FirstClearReward { get; set; }

        public CampaignTutorialStageResultResponse() { }
    }
}
