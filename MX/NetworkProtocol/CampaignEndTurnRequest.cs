namespace MX.NetworkProtocol
{
    public class CampaignEndTurnRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_EndTurn; }
        }

        public long StageUniqueId { get; set; }

        public CampaignEndTurnRequest() { }
    }
}
