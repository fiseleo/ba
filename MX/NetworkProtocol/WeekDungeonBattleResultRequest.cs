using MX.Logic.Battles.Summary;

namespace MX.NetworkProtocol
{
    public class WeekDungeonBattleResultRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WeekDungeon_BattleResult; }
        }

        public long StageUniqueId { get; set; }

        public bool PassCheckCharacter { get; set; }

        public BattleSummary Summary { get; set; }

        public WeekDungeonBattleResultRequest() { }
    }
}
