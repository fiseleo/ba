using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClanMyAssistListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_MyAssistList; }
        }

        public List<ClanAssistSlotDB> ClanAssistSlotDBs { get; set; }

        public ClanMyAssistListResponse() { }
    }
}
