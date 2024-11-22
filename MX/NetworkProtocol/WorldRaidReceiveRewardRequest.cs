namespace MX.NetworkProtocol
{
    public class WorldRaidReceiveRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.WorldRaid_ReceiveReward; }
        }

        public long SeasonId { get; set; }

        public WorldRaidReceiveRewardRequest() { }
    }
}
