namespace MX.NetworkProtocol
{
    [Obsolete("MultiRaid")]
    public class RaidCompleteListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_CompleteList; }
        }

        public RaidCompleteListRequest() { }
    }
}
