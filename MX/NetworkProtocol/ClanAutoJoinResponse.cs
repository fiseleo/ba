using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClanAutoJoinResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_AutoJoin; }
        }

        public IrcServerConfig IrcConfig { get; set; }

        public ClanDB ClanDB { get; set; }

        public ClanMemberDB ClanMemberDB { get; set; }

        public ClanAutoJoinResponse() { }
    }
}
