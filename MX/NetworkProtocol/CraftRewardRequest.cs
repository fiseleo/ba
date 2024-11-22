namespace MX.NetworkProtocol
{
    public class CraftRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_Reward; }
        }

        public long SlotId { get; set; }

        public CraftRewardRequest() { }
    }
}
