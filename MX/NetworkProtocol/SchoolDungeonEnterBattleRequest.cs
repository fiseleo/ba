namespace MX.NetworkProtocol
{
    public class SchoolDungeonEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.SchoolDungeon_EnterBattle; }
        }

        public long StageUniqueId { get; set; }

        public SchoolDungeonEnterBattleRequest() { }
    }
}
