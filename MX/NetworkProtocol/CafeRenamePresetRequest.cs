namespace MX.NetworkProtocol
{
    public class CafeRenamePresetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_RenamePreset; }
        }

        public int SlotId { get; set; }

        public string PresetName { get; set; }

        public CafeRenamePresetRequest() { }
    }
}
