namespace MX.NetworkProtocol
{
    public class EventContentFortuneGachaPurchaseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_FortuneGachaPurchase; }
        }

        public long EventContentId { get; set; }

        public EventContentFortuneGachaPurchaseRequest() { }
    }
}
