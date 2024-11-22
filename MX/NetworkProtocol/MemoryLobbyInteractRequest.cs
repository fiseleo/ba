namespace MX.NetworkProtocol
{
    public class MemoryLobbyInteractRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MemoryLobby_Interact; }
        }

        public MemoryLobbyInteractRequest() { }
    }
}
