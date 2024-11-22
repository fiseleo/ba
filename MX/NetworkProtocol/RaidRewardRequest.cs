namespace MX.NetworkProtocol
{
    public class RaidRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Raid_Reward; }
        }

        public long RaidServerId { get; set; }

        public bool IsPractice { get; set; }

        public RaidRewardRequest() { }
    }
}
