using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClanConferResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Confer; }
        }

        public ClanMemberDB ClanMemberDB { get; set; }

        public ClanMemberDB AccountClanMemberDB { get; set; }

        public ClanDB ClanDB { get; set; }

        public ClanMemberDescriptionDB ClanMemberDescriptionDB { get; set; }

        public ClanConferResponse() { }
    }
}
