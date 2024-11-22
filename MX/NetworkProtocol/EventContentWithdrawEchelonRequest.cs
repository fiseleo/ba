using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class EventContentWithdrawEchelonRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_WithdrawEchelon; }
        }

        public long EventContentId { get; set; }

        public long StageUniqueId { get; set; }

        public List<long> WithdrawEchelonEntityId { get; set; }

        public EventContentWithdrawEchelonRequest() { }
    }
}
