namespace MX.NetworkProtocol
{
    public class ArenaBattleResultResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_BattleResult; }
        }

        public ArenaBattleResultResponse() { }
    }
}
