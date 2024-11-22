namespace MX.NetworkProtocol
{
    public class ClanQuitResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Quit; }
        }

        public ClanQuitResponse() { }
    }
}
