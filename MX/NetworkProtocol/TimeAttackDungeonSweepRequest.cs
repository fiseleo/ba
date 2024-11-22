namespace MX.NetworkProtocol
{
    public class TimeAttackDungeonSweepRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.TimeAttackDungeon_Sweep; }
        }

        public long SweepCount { get; set; }

        public TimeAttackDungeonSweepRequest() { }
    }
}
