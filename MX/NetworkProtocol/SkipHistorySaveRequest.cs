using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class SkipHistorySaveRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.SkipHistory_Save; }
        }

        public SkipHistoryDB SkipHistoryDB { get; set; }

        public SkipHistorySaveRequest() { }
    }
}
