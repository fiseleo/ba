namespace MX.NetworkProtocol
{
    public class TimeAttackDungeonLoginRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TimeAttackDungeon_Login; }
        }

        public TimeAttackDungeonLoginRequest() { }
    }
}
