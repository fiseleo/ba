using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeAckResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_Ack; }
        }

        public CafeDB CafeDB { get; set; }

        public CafeAckResponse() { }
    }
}
