namespace MX.NetworkProtocol
{
    public class WeekDungeonListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WeekDungeon_List; }
        }

        public WeekDungeonListRequest() { }
    }
}
