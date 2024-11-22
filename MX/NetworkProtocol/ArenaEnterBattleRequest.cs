namespace MX.NetworkProtocol
{
    public class ArenaEnterBattleRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_EnterBattle; }
        }

        public long OpponentAccountServerId { get; set; }

        public long OpponentIndex { get; set; }

        public ArenaEnterBattleRequest() { }
    }
}
