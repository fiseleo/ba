namespace MX.NetworkProtocol
{
    [Obsolete("MultiRaid")]
    public class RaidShareRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_Share; }
        }

        public long RaidServerId { get; set; }

        public RaidShareRequest() { }
    }
}
