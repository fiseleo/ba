namespace MX.NetworkProtocol
{
    public class ArenaHistoryRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_History; }
        }

        public DateTime SearchStartDate { get; set; }

        public int Count { get; set; }

        public ArenaHistoryRequest() { }
    }
}
