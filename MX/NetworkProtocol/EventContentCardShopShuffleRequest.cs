namespace MX.NetworkProtocol
{
    public class EventContentCardShopShuffleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_CardShopShuffle; }
        }

        public long EventContentId { get; set; }

        public EventContentCardShopShuffleRequest() { }
    }
}
