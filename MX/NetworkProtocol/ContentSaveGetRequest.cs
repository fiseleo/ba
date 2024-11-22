namespace MX.NetworkProtocol
{
    public class ContentSaveGetRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ContentSave_Get; }
        }

        public ContentSaveGetRequest() { }
    }
}
