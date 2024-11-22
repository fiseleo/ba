namespace MX.NetworkProtocol
{
    public class StickerLoginRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Sticker_Login; }
        }

        public StickerLoginRequest() { }
    }
}
