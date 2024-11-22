using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class SkipHistoryListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.SkipHistory_List; }
        }

        public SkipHistoryDB SkipHistoryDB { get; set; }

        public SkipHistoryListResponse() { }
    }
}
