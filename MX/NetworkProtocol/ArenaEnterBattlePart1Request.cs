namespace MX.NetworkProtocol
{
    public class ArenaEnterBattlePart1Request : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_EnterBattlePart1; }
        }

        public long OpponentAccountServerId { get; set; }

        public long OpponentRank { get; set; }

        public int OpponentIndex { get; set; }

        public ArenaEnterBattlePart1Request() { }
    }
}
