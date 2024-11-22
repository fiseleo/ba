namespace MX.NetworkProtocol
{
    public class AttachmentGetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Attachment_Get; }
        }

        public AttachmentGetRequest() { }
    }
}
