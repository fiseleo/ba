using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class TimeAttackDungeonEnterBattleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TimeAttackDungeon_EnterBattle; }
        }

        public AssistCharacterDB AssistCharacterDB { get; set; }

        public TimeAttackDungeonEnterBattleResponse() { }
    }
}
