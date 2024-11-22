namespace MX.NetworkProtocol
{
    public class CampaignEnterTacticResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_EnterTactic; }
        }

        public CampaignEnterTacticResponse() { }
    }
}
