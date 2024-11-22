using FlatData;

namespace MX.NetworkProtocol
{
    public class RaidOpponentListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_OpponentList; }
        }
        public long? Rank { get; set; }
        public long? Score { get; set; }
        public bool IsUpper { get; set; }
        public bool IsFirstRequest { get; set; }
        public RankingSearchType SearchType { get; set; }
    }
}
