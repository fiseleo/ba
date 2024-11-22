namespace MX.NetworkProtocol
{
    public class CafeRenamePresetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_RenamePreset; }
        }

        public CafeRenamePresetResponse() { }
    }
}
