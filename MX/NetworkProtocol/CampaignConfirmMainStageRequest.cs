namespace MX.NetworkProtocol
{
    public class CampaignConfirmMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_ConfirmMainStage; }
        }

        public long StageUniqueId { get; set; }

        public CampaignConfirmMainStageRequest() { }
    }
}
