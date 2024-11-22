using MX.GameLogic.DBModel;

namespace MX.NetworkProtocol
{
    public class GetArenaTeamCheatResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.None; }
        }

        public ArenaUserDB Opponent { get; set; }

        public GetArenaTeamCheatResponse() { }
    }
}
