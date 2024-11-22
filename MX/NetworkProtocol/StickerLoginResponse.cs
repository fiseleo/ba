using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class StickerLoginResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Sticker_Login; }
        }

        public StickerBookDB StickerBookDB { get; set; }

        public StickerLoginResponse() { }
    }
}
