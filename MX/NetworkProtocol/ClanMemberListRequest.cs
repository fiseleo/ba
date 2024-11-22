namespace MX.NetworkProtocol
{
    public class ClanMemberListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_MemberList; }
        }
        public long ClanDBId { get; set; }
    }
}
