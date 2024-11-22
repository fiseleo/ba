namespace MX.NetworkProtocol
{
    public class ContentSweepMultiSweepPresetListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ContentSweep_MultiSweepPresetList; }
        }

        public ContentSweepMultiSweepPresetListRequest() { }
    }
}
