namespace MX.NetworkProtocol
{
    public class EventRewardIncreaseRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Event_RewardIncrease; }
        }

        public EventRewardIncreaseRequest() { }
    }
}
