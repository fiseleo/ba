namespace MX.NetworkProtocol
{
    public class EventContentDiceRaceLapRewardRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.EventContent_DiceRaceLapReward; }
        }

        public long EventContentId { get; set; }

        public EventContentDiceRaceLapRewardRequest() { }
    }
}
