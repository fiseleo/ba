using MX.Campaign;

namespace MX.NetworkProtocol
{
    public class EventContentMapMoveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_MapMove; }
        }

        public long EventContentId { get; set; }

        public long StageUniqueId { get; set; }

        public long EchelonEntityId { get; set; }

        public HexLocation DestPosition { get; set; }

        public EventContentMapMoveRequest() { }
    }
}
