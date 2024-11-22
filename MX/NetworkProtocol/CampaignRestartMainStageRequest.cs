namespace MX.NetworkProtocol
{
    public class CampaignRestartMainStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_RestartMainStage; }
        }

        public long StageUniqueId { get; set; }

        public CampaignRestartMainStageRequest() { }
    }
}
