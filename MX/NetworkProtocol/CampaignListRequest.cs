namespace MX.NetworkProtocol
{
    public class CampaignListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_List; }
        }

        public CampaignListRequest() { }
    }
}
