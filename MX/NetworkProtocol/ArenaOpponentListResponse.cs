using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ArenaOpponentListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_OpponentList; }
        }

        public long PlayerRank { get; set; }

        public List<ArenaUserDB> OpponentUserDBs { get; set; }

        public DateTime AutoRefreshTime { get; set; }

        public ArenaOpponentListResponse() { }
    }
}
