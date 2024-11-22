namespace MX.NetworkProtocol
{
    public class CraftRewardAllRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_RewardAll; }
        }

        public CraftRewardAllRequest() { }
    }
}
