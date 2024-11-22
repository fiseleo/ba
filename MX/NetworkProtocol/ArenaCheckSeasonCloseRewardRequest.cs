namespace MX.NetworkProtocol
{
    public class ArenaCheckSeasonCloseRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_CheckSeasonCloseReward; }
        }

        public ArenaCheckSeasonCloseRewardRequest() { }
    }
}
