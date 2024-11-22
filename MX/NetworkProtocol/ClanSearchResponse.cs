using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClanSearchResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Search; }
        }

        public List<ClanDB> ClanDBs { get; set; }

        public ClanSearchResponse() { }
    }
}
