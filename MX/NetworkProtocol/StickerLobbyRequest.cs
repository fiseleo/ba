using System.Collections.Generic;

namespace MX.NetworkProtocol
{
    public class StickerLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Sticker_Lobby; }
        }

        public IEnumerable<long> AcquireStickerUniqueIds { get; set; }

        public StickerLobbyRequest() { }
    }
}
