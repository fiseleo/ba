namespace MX.NetworkProtocol
{
    public class WorldRaidBossListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WorldRaid_BossList; }
        }

        public long SeasonId { get; set; }

        public bool RequestOnlyWorldBossData { get; set; }

        public WorldRaidBossListRequest() { }
    }
}
