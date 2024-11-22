namespace MX.NetworkProtocol
{
    public class SchoolDungeonRetreatRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.SchoolDungeon_Retreat; }
        }

        public long StageUniqueId { get; set; }

        public SchoolDungeonRetreatRequest() { }
    }
}
