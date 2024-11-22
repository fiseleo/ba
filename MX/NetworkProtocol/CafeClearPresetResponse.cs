namespace MX.NetworkProtocol
{
    public class CafeClearPresetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Cafe_ClearPreset; }
        }

        public CafeClearPresetResponse() { }
    }
}
