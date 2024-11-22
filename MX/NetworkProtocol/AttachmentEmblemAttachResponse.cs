using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class AttachmentEmblemAttachResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Attachment_EmblemAttach; }
        }

        public AccountAttachmentDB AttachmentDB { get; set; }

        public AttachmentEmblemAttachResponse() { }
    }
}
