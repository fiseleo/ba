namespace MX.NetworkProtocol
{
    public class CraftShiftingRewardAllRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_ShiftingRewardAll; }
        }

        public CraftShiftingRewardAllRequest() { }
    }
}
