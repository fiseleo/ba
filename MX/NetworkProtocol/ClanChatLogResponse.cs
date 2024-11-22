namespace MX.NetworkProtocol
{
    public class ClanChatLogResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_ChatLog; }
        }

        public string ClanChatLog { get; set; }

        public ClanChatLogResponse() { }
    }
}
