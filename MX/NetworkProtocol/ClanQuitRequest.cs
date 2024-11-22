namespace MX.NetworkProtocol
{
    public class ClanQuitRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Quit; }
        }

        public ClanQuitRequest() { }
    }
}
