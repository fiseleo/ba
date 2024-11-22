namespace MX.NetworkProtocol
{
    public class CafeListPresetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_ListPreset; }
        }

        public CafeListPresetRequest() { }
    }
}
