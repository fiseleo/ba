using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CampaignPortalResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_Portal; }
        }

        public CampaignMainStageSaveDB CampaignMainStageSaveDB { get; set; }

        public CampaignPortalResponse() { }
    }
}
