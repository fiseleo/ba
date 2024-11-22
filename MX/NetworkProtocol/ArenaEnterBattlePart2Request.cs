using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ArenaEnterBattlePart2Request : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_EnterBattlePart2; }
        }

        public ArenaBattleDB ArenaBattleDB { get; set; }

        public ArenaEnterBattlePart2Request() { }
    }
}
