namespace MX.NetworkProtocol
{
    public class MemoryLobbySetMainRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MemoryLobby_SetMain; }
        }

        public long MemoryLobbyId { get; set; }

        public MemoryLobbySetMainRequest() { }
    }
}
