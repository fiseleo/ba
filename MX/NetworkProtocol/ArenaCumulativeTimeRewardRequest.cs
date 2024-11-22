namespace MX.NetworkProtocol
{
    public class ArenaCumulativeTimeRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Arena_CumulativeTimeReward; }
        }

        public ArenaCumulativeTimeRewardRequest() { }
    }
}
