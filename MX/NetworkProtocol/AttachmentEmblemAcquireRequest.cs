using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class AttachmentEmblemAcquireRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Attachment_EmblemAcquire; }
        }

        public List<long> UniqueIds { get; set; }

        public AttachmentEmblemAcquireRequest() { }
    }
}
