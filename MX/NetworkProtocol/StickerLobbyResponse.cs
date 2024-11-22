using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class StickerLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Sticker_Lobby; }
        }

        public IEnumerable<StickerDB> ReceivedStickerDBs { get; set; }

        public StickerBookDB StickerBookDB { get; set; }

        public StickerLobbyResponse() { }
    }
}
