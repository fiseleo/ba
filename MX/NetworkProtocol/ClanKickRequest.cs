namespace MX.NetworkProtocol
{
    public class ClanKickRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Kick; }
        }

        public long MemberAccountId { get; set; }

        public ClanKickRequest() { }
    }
}
