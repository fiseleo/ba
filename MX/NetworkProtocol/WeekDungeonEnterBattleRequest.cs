namespace MX.NetworkProtocol
{
    public class WeekDungeonEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WeekDungeon_EnterBattle; }
        }

        public long StageUniqueId { get; set; }

        public long EchelonIndex { get; set; }

        public WeekDungeonEnterBattleRequest() { }
    }
}
