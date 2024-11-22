namespace MX.NetworkProtocol
{
    public class WeekDungeonRetreatRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WeekDungeon_Retreat; }
        }

        public long StageUniqueId { get; set; }

        public WeekDungeonRetreatRequest() { }
    }
}
