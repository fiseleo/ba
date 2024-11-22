using FlatData;

namespace MX.NetworkProtocol
{
    public class ContentSweepRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ContentSweep_Request; }
        }

        public ContentType Content { get; set; }

        public long StageId { get; set; }

        public long EventContentId { get; set; }

        public long Count { get; set; }

        public ContentSweepRequest() { }
    }
}
