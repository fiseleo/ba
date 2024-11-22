namespace MX.NetworkProtocol
{
    public class AttachmentEmblemListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Attachment_EmblemList; }
        }

        public AttachmentEmblemListRequest() { }
    }
}
