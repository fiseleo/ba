namespace MX.NetworkProtocol
{
    public class CafeApplyPresetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_ApplyPreset; }
        }

        public int SlotId { get; set; }

        public long CafeDBId { get; set; }

        public bool UseOtherCafeFurniture { get; set; }

        public CafeApplyPresetRequest() { }
    }
}
