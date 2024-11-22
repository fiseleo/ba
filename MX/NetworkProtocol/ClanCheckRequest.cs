namespace MX.NetworkProtocol
{
    public class ClanCheckRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Check; }
        }

        public ClanCheckRequest() { }
    }
}
