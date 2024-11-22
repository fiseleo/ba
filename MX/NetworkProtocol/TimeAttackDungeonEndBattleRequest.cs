using MX.GameLogic.DBModel;
using MX.Logic.Battles.Summary;

namespace MX.NetworkProtocol
{
    public class TimeAttackDungeonEndBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TimeAttackDungeon_EndBattle; }
        }

        public int EchelonId { get; set; }

        public long RoomId { get; set; }

        public BattleSummary Summary { get; set; }

        public ClanAssistUseInfo AssistUseInfo { get; set; }

        public TimeAttackDungeonEndBattleRequest() { }
    }
}
