namespace MX.NetworkProtocol
{
    public class EventContentSelectBuffRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_SelectBuff; }
        }

        public long SelectedBuffId { get; set; }

        public EventContentSelectBuffRequest() { }
    }
}
