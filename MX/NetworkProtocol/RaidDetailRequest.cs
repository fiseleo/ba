namespace MX.NetworkProtocol
{
    [Obsolete("MultiRaid")]
    public class RaidDetailRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_Detail; }
        }

        public long RaidServerId { get; set; }

        public long RaidUniqueId { get; set; }

        public RaidDetailRequest() { }
    }
}
