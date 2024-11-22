namespace MX.NetworkProtocol
{
    public class ArenaCheckSeasonCloseRewardResponse : ResponsePacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_CheckSeasonCloseReward; }
        }

        public ArenaCheckSeasonCloseRewardResponse() { }
    }
}
