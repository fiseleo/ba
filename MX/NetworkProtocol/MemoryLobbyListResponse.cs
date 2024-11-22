using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class MemoryLobbyListResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.MemoryLobby_List; }
        }

        public List<MemoryLobbyDB> MemoryLobbyDBs { get; set; }

        public MemoryLobbyListResponse() { }
    }
}
