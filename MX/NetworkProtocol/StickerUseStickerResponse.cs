using MX.GameLogic.DBModel;
using MX.GameLogic.Parcel;

namespace MX.NetworkProtocol
{
    public class StickerUseStickerResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Sticker_UseSticker; }
        }

        public StickerBookDB StickerBookDB { get; set; }

        public ParcelResultDB ParcelResultDB { get; set; }

        public StickerUseStickerResponse() { }
    }
}
