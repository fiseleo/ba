namespace MX.NetworkProtocol
{
    public class EliminateRaidSweepRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EliminateRaid_Sweep; }
        }

        public long UniqueId { get; set; }

        public int SweepCount { get; set; }

        public EliminateRaidSweepRequest() { }
    }
}
