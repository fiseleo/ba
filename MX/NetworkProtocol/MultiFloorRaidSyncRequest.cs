namespace MX.NetworkProtocol
{
    public class MultiFloorRaidSyncRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MultiFloorRaid_Sync; }
        }

        public long? SeasonId { get; set; }

        public MultiFloorRaidSyncRequest() { }
    }
}
