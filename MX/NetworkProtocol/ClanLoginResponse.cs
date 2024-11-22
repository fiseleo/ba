using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClanLoginResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Login; }
        }

        public ClanDB AccountClanDB { get; set; }

        public ClanMemberDB AccountClanMemberDB { get; set; }

        [Obsolete]
        public List<AssistCharacterDB> AssistCharacterDBs { get; set; }

        public List<ClanAssistSlotDB> ClanAssistSlotDBs { get; set; }

        public ClanLoginResponse() { }
    }
}
