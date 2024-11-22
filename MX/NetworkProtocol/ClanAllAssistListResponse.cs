using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClanAllAssistListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_AllAssistList; }
        }

        public List<AssistCharacterDB> AssistCharacterDBs { get; set; }

        public List<ClanAssistRentHistoryDB> AssistCharacterRentHistoryDBs { get; set; }

        public long ClanDBId { get; set; }

        public ClanAllAssistListResponse() { }
    }
}
