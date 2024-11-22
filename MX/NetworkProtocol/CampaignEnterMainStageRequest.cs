namespace MX.NetworkProtocol
{
    public class CampaignEnterMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_EnterMainStage; }
        }

        public long StageUniqueId { get; set; }

        public CampaignEnterMainStageRequest() { }
    }
}
