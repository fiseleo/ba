using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ArenaEnterBattlePart1Response : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_EnterBattlePart1; }
        }

        public ArenaBattleDB ArenaBattleDB { get; set; }

        public ArenaEnterBattlePart1Response() { }
    }
}
