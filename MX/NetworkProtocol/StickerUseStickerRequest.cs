namespace MX.NetworkProtocol
{
    public class StickerUseStickerRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Sticker_UseSticker; }
        }

        public long StickerUniqueId { get; set; }

        public StickerUseStickerRequest() { }
    }
}
