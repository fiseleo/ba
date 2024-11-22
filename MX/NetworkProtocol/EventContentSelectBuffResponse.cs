using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentSelectBuffResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_SelectBuff; }
        }

        public EventContentMainStageSaveDB SaveDataDB { get; set; }

        public EventContentSelectBuffResponse() { }
    }
}
