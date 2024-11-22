namespace MX.NetworkProtocol
{
    public class EventListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Event_GetList; }
        }

        public EventListRequest() { }
    }
}
