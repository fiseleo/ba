using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class CraftCompleteProcessAllResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Craft_CompleteProcessAll; }
        }

        public List<CraftInfoDB> CraftInfoDBs { get; set; }

        public ItemDB TicketItemDB { get; set; }

        public CraftCompleteProcessAllResponse() { }
    }
}
