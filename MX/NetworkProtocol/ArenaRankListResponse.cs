using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ArenaRankListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_RankList; }
        }

        public List<ArenaUserDB> TopRankedUserDBs { get; set; }

        public ArenaRankListResponse() { }
    }
}
