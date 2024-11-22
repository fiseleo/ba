namespace MX.NetworkProtocol
{
    public class CraftShiftingCompleteProcessRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_ShiftingCompleteProcess; }
        }

        public long SlotId { get; set; }

        public CraftShiftingCompleteProcessRequest() { }
    }
}
