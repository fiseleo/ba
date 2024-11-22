namespace MX.NetworkProtocol
{
    public class ClanLoginRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Login; }
        }

        public ClanLoginRequest() { }
    }
}
