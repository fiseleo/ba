using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class ContentSaveDiscardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ContentSave_Discard; }
        }

        public ParcelResultDB ParcelResultDB { get; set; }

        public ContentSaveDiscardResponse() { }
    }
}
