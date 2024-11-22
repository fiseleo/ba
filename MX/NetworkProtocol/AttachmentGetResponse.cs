using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class AttachmentGetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Attachment_Get; }
        }

        public AccountAttachmentDB AccountAttachmentDB { get; set; }

        public AttachmentGetResponse() { }
    }
}
