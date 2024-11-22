using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CafeTrophyHistoryResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_TrophyHistory; }
        }

        public List<RaidSeasonRankingHistoryDB> RaidSeasonRankingHistoryDBs { get; set; }

        public CafeTrophyHistoryResponse() { }
    }
}
