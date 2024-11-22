namespace MX.NetworkProtocol
{
    [Obsolete("MultiRaid")]
    public class RaidRewardAllRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_RewardAll; }
        }

        public RaidRewardAllRequest() { }
    }
}
