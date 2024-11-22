namespace MX.NetworkProtocol
{
    public class SchoolDungeonListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.SchoolDungeon_List; }
        }

        public SchoolDungeonListRequest() { }
    }
}
