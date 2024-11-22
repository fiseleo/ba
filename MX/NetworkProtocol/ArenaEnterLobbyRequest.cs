namespace MX.NetworkProtocol
{
    public class ArenaEnterLobbyRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_EnterLobby; }
        }

        public ArenaEnterLobbyRequest() { }
    }
}
