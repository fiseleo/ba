using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class MemoryLobbySetMainResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MemoryLobby_SetMain; }
        }

        public AccountDB AccountDB { get; set; }

        public MemoryLobbySetMainResponse() { }
    }
}
