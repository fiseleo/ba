using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClanLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Lobby; }
        }

        public IrcServerConfig IrcConfig { get; set; }

        public ClanDB AccountClanDB { get; set; }

        public List<ClanDB> DefaultExposedClanDBs { get; set; }

        public ClanMemberDB AccountClanMemberDB { get; set; }

        public List<ClanMemberDB> ClanMemberDBs { get; set; }

        public ClanLobbyResponse() { }
    }
}
