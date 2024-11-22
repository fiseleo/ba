using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentLocationGetInfoResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_LocationGetInfo; }
        }

        public EventContentLocationDB EventContentLocationDB { get; set; }

        public EventContentLocationGetInfoResponse() { }
    }
}
