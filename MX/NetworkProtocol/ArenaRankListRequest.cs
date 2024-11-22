namespace MX.NetworkProtocol
{
    public class ArenaRankListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_RankList; }
        }

        public int StartIndex { get; set; }

        public int Count { get; set; }

        public ArenaRankListRequest() { }
    }
}
