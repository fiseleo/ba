using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ArenaBattleResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_BattleResult; }
        }

        public ArenaBattleDB ArenaBattleDB { get; set; }

        public ArenaBattleResultRequest() { }
    }
}
