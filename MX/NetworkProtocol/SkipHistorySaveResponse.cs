using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class SkipHistorySaveResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.SkipHistory_Save; }
        }

        public SkipHistoryDB SkipHistoryDB { get; set; }

        public SkipHistorySaveResponse() { }
    }
}
