namespace MX.NetworkProtocol
{
    public class ArenaOpponentListRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_OpponentList; }
        }

        public ArenaOpponentListRequest() { }
    }
}
