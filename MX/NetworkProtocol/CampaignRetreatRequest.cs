namespace MX.NetworkProtocol
{
    public class CampaignRetreatRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_Retreat; }
        }

        public long StageUniqueId { get; set; }

        public CampaignRetreatRequest() { }
    }
}
