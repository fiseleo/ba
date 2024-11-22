namespace MX.NetworkProtocol
{
    public class EventImageResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Event_GetImage; }
        }

        public byte[] ImageBytes { get; set; }

        public EventImageResponse() { }
    }
}
