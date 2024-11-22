namespace MX.NetworkProtocol
{
    public class ClanLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Clan_Lobby; }
        }

        public ClanLobbyRequest() { }
    }
}
