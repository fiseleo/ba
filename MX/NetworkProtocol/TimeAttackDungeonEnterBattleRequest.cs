using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class TimeAttackDungeonEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TimeAttackDungeon_EnterBattle; }
        }

        public long RoomId { get; set; }

        public ClanAssistUseInfo AssistUseInfo { get; set; }

        public TimeAttackDungeonEnterBattleRequest() { }
    }
}
