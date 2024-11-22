using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EliminateRaidOpponentListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_OpponentList; }
        }
        public List<EliminateRaidUserDB> OpponentUserDBs { get; set; }
    }
}
