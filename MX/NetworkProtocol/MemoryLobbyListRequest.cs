namespace MX.NetworkProtocol
{
    public class MemoryLobbyListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MemoryLobby_List; }
        }

        public MemoryLobbyListRequest() { }
    }
}
