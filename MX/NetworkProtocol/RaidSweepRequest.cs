namespace MX.NetworkProtocol
{
    public class RaidSweepRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_Sweep; }
        }

        public long UniqueId { get; set; }

        public long SweepCount { get; set; }

        public RaidSweepRequest() { }
    }
}
