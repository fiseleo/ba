namespace MX.NetworkProtocol
{
    public class ClanChatLogRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_ChatLog; }
        }

        public string Channel { get; set; }

        public DateTime FromDate { get; set; }

        public ClanChatLogRequest() { }
    }
}
