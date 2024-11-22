using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClanMemberResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Member; }
        }

        public ClanDB ClanDB { get; set; }

        public ClanMemberDB ClanMemberDB { get; set; }

        public DetailedAccountInfoDB DetailedAccountInfoDB { get; set; }

        public ClanMemberResponse() { }
    }
}
