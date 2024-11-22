namespace MX.NetworkProtocol
{
    public class ContentSweepSetMultiSweepPresetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ContentSweep_SetMultiSweepPreset; }
        }

        public ContentSweepSetMultiSweepPresetResponse() { }
    }
}
