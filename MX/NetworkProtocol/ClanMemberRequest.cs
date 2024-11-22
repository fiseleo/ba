namespace MX.NetworkProtocol
{
    public class ClanMemberRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Member; }
        }

        public long ClanDBId { get; set; }

        public long MemberAccountId { get; set; }

        public ClanMemberRequest() { }
    }
}
