namespace MX.NetworkProtocol
{
    public class CafeClearPresetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_ClearPreset; }
        }

        public int SlotId { get; set; }

        public CafeClearPresetRequest() { }
    }
}
