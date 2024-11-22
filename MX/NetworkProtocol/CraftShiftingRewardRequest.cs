namespace MX.NetworkProtocol
{
    public class CraftShiftingRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_ShiftingReward; }
        }

        public long SlotId { get; set; }

        public CraftShiftingRewardRequest() { }
    }
}
