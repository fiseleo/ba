using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class EliminateRaidEndBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_EndBattle; }
        }

        public long RankingPoint { get; set; }

        public long BestRankingPoint { get; set; }

        public long ClearTimePoint { get; set; }

        public long HPPercentScorePoint { get; set; }

        public long DefaultClearPoint { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public EliminateRaidEndBattleResponse() { }
    }
}
