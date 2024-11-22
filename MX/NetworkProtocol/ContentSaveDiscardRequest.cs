using FlatData;

namespace MX.NetworkProtocol
{
    public class ContentSaveDiscardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ContentSave_Discard; }
        }

        public ContentType ContentType { get; set; }

        public long StageUniqueId { get; set; }

        public ContentSaveDiscardRequest() { }
    }
}
