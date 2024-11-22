namespace MX.NetworkProtocol
{
    public class CampaignEnterTutorialStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_EnterTutorialStage; }
        }

        public long StageUniqueId { get; set; }

        public CampaignEnterTutorialStageRequest() { }
    }
}
