namespace MX.NetworkProtocol
{
    public class TimeAttackDungeonGiveUpRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TimeAttackDungeon_GiveUp; }
        }

        public long RoomId { get; set; }

        public TimeAttackDungeonGiveUpRequest() { }
    }
}
