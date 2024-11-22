using FlatData;

namespace MX.NetworkProtocol
{
    public class EliminateRaidOpponentListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_OpponentList; }
        }
        public long? Rank { get; set; }
        public long? Score { get; set; }
        public int? BossGroupIndex { get; set; }
        public bool IsUpper { get; set; }
        public bool IsFirstRequest { get; set; }
        public RankingSearchType SearchType { get; set; }
    }
}
