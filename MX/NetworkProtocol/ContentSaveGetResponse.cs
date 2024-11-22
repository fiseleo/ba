using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ContentSaveGetResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ContentSave_Get; }
        }

        public bool HasValidData { get; set; }

        public ContentSaveDB ContentSaveDB { get; set; }

        public EventContentChangeDB EventContentChangeDB { get; set; }

        public ContentSaveGetResponse() { }
    }
}
