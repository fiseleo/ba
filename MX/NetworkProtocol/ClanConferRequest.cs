using FlatData;

namespace MX.NetworkProtocol
{
    public class ClanConferRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Confer; }
        }

        public long MemberAccountId { get; set; }

        public ClanSocialGrade ConferingGrade { get; set; }

        public ClanConferRequest() { }
    }
}
