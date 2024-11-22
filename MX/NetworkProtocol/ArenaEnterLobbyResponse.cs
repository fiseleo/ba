using System.Collections.Generic;
using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class ArenaEnterLobbyResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_EnterLobby; }
        }

        public ArenaPlayerInfoDB ArenaPlayerInfoDB { get; set; }

        public List<ArenaUserDB> OpponentUserDBs { get; set; }

        public long MapId { get; set; }

        public DateTime AutoRefreshTime { get; set; }

        public ArenaEnterLobbyResponse() { }
    }
}
