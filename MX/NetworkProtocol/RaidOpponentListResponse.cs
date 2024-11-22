using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class RaidOpponentListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_OpponentList; }
        }

        public List<SingleRaidUserDB> OpponentUserDBs { get; set; }

        public RaidOpponentListResponse() { }
    }
}
