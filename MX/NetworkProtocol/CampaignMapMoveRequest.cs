using MX.Campaign;

namespace MX.NetworkProtocol
{
    public class CampaignMapMoveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Campaign_MapMove; }
        }

        public long StageUniqueId { get; set; }

        public long EchelonEntityId { get; set; }

        public HexLocation DestPosition { get; set; }

        public CampaignMapMoveRequest() { }
    }
}
