namespace MX.NetworkProtocol
{
    public class MemoryLobbyUpdateLobbyModeResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MemoryLobby_UpdateLobbyMode; }
        }

        public MemoryLobbyUpdateLobbyModeResponse() { }
    }
}
