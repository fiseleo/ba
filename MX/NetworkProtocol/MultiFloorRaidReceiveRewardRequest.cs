namespace MX.NetworkProtocol
{
    public class MultiFloorRaidReceiveRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MultiFloorRaid_ReceiveReward; }
        }

        public long SeasonId { get; set; }

        public int RewardDifficulty { get; set; }

        public MultiFloorRaidReceiveRewardRequest() { }
    }
}
