namespace MX.NetworkProtocol
{
    public class ClanMyAssistListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_MyAssistList; }
        }

        public ClanMyAssistListRequest() { }
    }
}
