namespace MX.NetworkProtocol
{
    public class CampaignHealRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_Heal; }
        }

        public long CampaignStageUniqueId { get; set; }

        public long EchelonIndex { get; set; }

        public long CharacterServerId { get; set; }

        public CampaignHealRequest() { }
    }
}
