namespace MX.NetworkProtocol
{
    public class AttachmentEmblemAttachRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Attachment_EmblemAttach; }
        }

        public long UniqueId { get; set; }

        public AttachmentEmblemAttachRequest() { }
    }
}
