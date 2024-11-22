using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ClanMemberListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_MemberList; }
        }
        public ClanDB ClanDB { get; set; }
        public List<ClanMemberDB> ClanMemberDBs { get; set; }
    }
}
