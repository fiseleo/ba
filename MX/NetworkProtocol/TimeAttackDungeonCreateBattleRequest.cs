namespace MX.NetworkProtocol
{
    public class TimeAttackDungeonCreateBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TimeAttackDungeon_CreateBattle; }
        }

        public bool IsPractice { get; set; }

        public TimeAttackDungeonCreateBattleRequest() { }
    }
}
