namespace MX.NetworkProtocol
{
    public class CampaignEnterTacticRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_EnterTactic; }
        }

        public long StageUniqueId { get; set; }

        public long EchelonIndex { get; set; }

        public long EnemyIndex { get; set; }

        public CampaignEnterTacticRequest() { }
    }
}
