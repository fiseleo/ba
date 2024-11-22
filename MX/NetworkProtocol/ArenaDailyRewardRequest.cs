namespace MX.NetworkProtocol
{
    public class ArenaDailyRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_DailyReward; }
        }

        public ArenaDailyRewardRequest() { }
    }
}
