using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class EventContentCardShopShuffleResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_CardShopShuffle; }
        }

        public List<CardShopElementDB> CardShopElementDBs { get; set; }

        public EventContentCardShopShuffleResponse() { }
    }
}
