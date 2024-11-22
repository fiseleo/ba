using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClearDeckListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.ClearDeck_List; }
        }

        public List<ClearDeckDB> ClearDeckDBs { get; set; }

        public ClearDeckListResponse() { }
    }
}
