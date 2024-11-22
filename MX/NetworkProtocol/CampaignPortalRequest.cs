namespace MX.NetworkProtocol
{
    public class CampaignPortalRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_Portal; }
        }

        public long StageUniqueId { get; set; }

        public long EchelonEntityId { get; set; }

        public CampaignPortalRequest() { }
    }
}
