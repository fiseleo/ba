using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentPortalResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_Portal; }
        }

        public EventContentMainStageSaveDB SaveDataDB { get; set; }

        public EventContentPortalResponse() { }
    }
}
