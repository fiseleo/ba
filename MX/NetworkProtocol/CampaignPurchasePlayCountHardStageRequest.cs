namespace MX.NetworkProtocol
{
    public class CampaignPurchasePlayCountHardStageRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_PurchasePlayCountHardStage; }
        }

        public long StageUniqueId { get; set; }

        public CampaignPurchasePlayCountHardStageRequest() { }
    }
}
