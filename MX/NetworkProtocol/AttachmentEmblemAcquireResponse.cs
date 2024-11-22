using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class AttachmentEmblemAcquireResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Attachment_EmblemAcquire; }
        }

        public List<EmblemDB> EmblemDBs { get; set; }

        public AttachmentEmblemAcquireResponse() { }
    }
}
