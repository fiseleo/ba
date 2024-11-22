namespace MX.NetworkProtocol
{
    public class ClanJoinRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Join; }
        }

        public long ClanDBId { get; set; }

        public ClanJoinRequest() { }
    }
}
