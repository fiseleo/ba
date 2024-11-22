using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentSubEventLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_SubEventLobby; }
        }

        public EventContentChangeDB EventContentChangeDB { get; set; }

        public bool IsOnSubEvent { get; set; }

        public EventContentSubEventLobbyResponse() { }
    }
}
