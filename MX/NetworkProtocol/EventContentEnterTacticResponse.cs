namespace MX.NetworkProtocol
{
    public class EventContentEnterTacticResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_EnterTactic; }
        }

        public EventContentEnterTacticResponse() { }
    }
}
