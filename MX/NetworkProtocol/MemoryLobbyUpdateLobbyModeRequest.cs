namespace MX.NetworkProtocol
{
    public class MemoryLobbyUpdateLobbyModeRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MemoryLobby_UpdateLobbyMode; }
        }

        public bool IsMemoryLobbyMode { get; set; }

        public MemoryLobbyUpdateLobbyModeRequest() { }
    }
}
