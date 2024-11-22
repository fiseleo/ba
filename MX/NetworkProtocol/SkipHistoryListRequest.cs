namespace MX.NetworkProtocol
{
    public class SkipHistoryListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.SkipHistory_List; }
        }

        public SkipHistoryListRequest() { }
    }
}
