namespace MX.NetworkProtocol
{
    public class ClanCheckResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Check; }
        }

        public ClanCheckResponse() { }
    }
}
