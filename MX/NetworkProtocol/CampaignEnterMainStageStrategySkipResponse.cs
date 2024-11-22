using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class CampaignEnterMainStageStrategySkipResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_EnterMainStageStrategySkip; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public CampaignEnterMainStageStrategySkipResponse() { }
    }
}
