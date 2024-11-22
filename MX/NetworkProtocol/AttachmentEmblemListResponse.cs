using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class AttachmentEmblemListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Attachment_EmblemList; }
        }

        public List<EmblemDB> EmblemDBs { get; set; }

        public AttachmentEmblemListResponse() { }
    }
}
