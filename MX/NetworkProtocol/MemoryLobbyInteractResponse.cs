namespace MX.NetworkProtocol
{
    public class MemoryLobbyInteractResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MemoryLobby_Interact; }
        }

        public MemoryLobbyInteractResponse() { }
    }
}
