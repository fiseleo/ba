namespace MX.NetworkProtocol
{
    public class CampaignConfirmTutorialStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_ConfirmTutorialStage; }
        }

        public long StageUniqueId { get; set; }

        public CampaignConfirmTutorialStageRequest() { }
    }
}
